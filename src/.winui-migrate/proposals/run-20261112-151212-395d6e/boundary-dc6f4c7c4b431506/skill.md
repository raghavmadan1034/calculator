---
name: winui2-to-winui3-test-host
version: 0.2.4
owner: sachikumar@microsoft.com
description: Use when a UWP or partially migrated WinUI test application still starts UnitTestClient, reports TestExecutor errors, or lacks a coherent UI-thread-aware test runner. Ports a recognized bootstrap, reviewed test packages, application definition and runner together without deleting tests or changing package identity.
user-invocable: false
kind: repair
pack: uwp
verify: test-host-compatibility, test
applies-to-message:
  - UnitTestClient
  - TestExecutor
---

# WinUI test hosting

A test application is not repaired merely by adding a test SDK. Keep its XAML application
definition, actual tests, UI-thread access and package identity consistent with its runner.
Do not turn it into a headless library or disable tests to obtain a passing build.

## Steps

The registered `MigrateWinUiTestHost` action targets the owning `.csproj`. The
`mstest-winui-mtp-v1` profile uses a self-hosted Microsoft.Testing.Platform runner on .NET 8+
with a Windows target-platform version of at least `10.0.19041.0`. The deployment minimum
is a separate property and is not raised by this recipe.

1. Identify the application definition and its code-behind. An explicit nonstandard name
   is supported; do not rename it to App.xaml. An implicit App.xaml is made explicit so
   disabling duplicate default application definitions does not lose the generated entry point.
2. Establish packaging and trust separately. Unpackaged desktop and packaged full-trust
   desktop hosts are supported. AppContainer hosts are not this profile; preserve them
   for a supported host/trust decision rather than silently changing identity or sandboxing.
3. Resolve the coherent package set through the app's configured feeds during assessment:
   stable `MSTest` in `[4.4.0,5.0.0)` and, for packaged hosts, stable
   `Microsoft.Testing.Extensions.PackagedApp` in `[2.4.0,3.0.0)`.
   Execution requires those exact reviewed pins. Do not invent a version, change a feed,
   or assume that features on an upstream main branch are in an older published package.
   MSTest 4 replaces the old exact-type `Assert.ThrowsExceptionAsync<T>` assertion with
   `Assert.ThrowsExactlyAsync<T>`. The deterministic repair renames only compiler-reported
   `Assert` invocations at their exact source lines; it does not rewrite other receivers or
   choose the relaxed `ThrowsAsync<T>` behavior.
4. Inspect the launch override. The automatic recipe accepts the canonical
   `UnitTestClient.CreateDefaultUI()` followed by `UnitTestClient.Run(args.Arguments)`,
   with a recognized empty previous-execution-state check and the ordinary DEBUG-only
   `DebugSettings.EnableFrameRateCounter = true` bootstrap. Both Debug and Release branches
   are inspected; the condition and debugger guard are retained. Conditional method declarations,
   other symbols, custom services, argument builders, imported/central package configurations and
   unsupported launch shapes remain unchanged and produce a capability requirement.
5. Propose `MigrateWinUiTestHost` against the project. It updates the bootstrap and test
   package/property contract together, publishes the retained Window's dispatcher, calls
   generated extension registration, propagates the runner exit code, and exits the app.
   The planner appends restore. Do not separately register a second packaged-app launcher.
6. Generated `SelfRegisteredExtensions` belongs to the project's **RootNamespace**, not
   necessarily the XAML application's namespace. The recipe uses the project namespace;
   the optional `rootNamespace` parameter supplies an explicitly established value when needed.

The tool rejects unsupported cases before writing. It retains all test source and assertions.
An I/O failure after a write reports the actual modified files and partial patch; do not assume
that a failed multi-file step wrote nothing.

## Checking it worked

Build first, then run the profile through `dotnet run --no-build --no-restore`, passing MTP's
`--report-trx`, `--report-trx-filename` and `--results-directory` after `--`. VSTest's
`--logger` syntax is not the runner contract for this profile. The evaluator builds the
complete project/configuration/platform argument list.

Require a real TRX with executed tests and no failures. Exit zero without a TRX, zero tests,
skipped-only tests and a successful build are not test passes. Check an intentionally failing
test when validating a new profile implementation.

For packaged hosts, verify package identity and real activation, not just direct execution.
Registration may require developer/sideloading policy already enabled. Never enable machine
policy or install trust certificates silently. A packaged activation does not necessarily
inherit the controller's environment: check that its required runtime is installed/configured.
Do not add permissive runtime roll-forward settings to a user's app to hide that blocker.

Reference checks cover both packaged and unpackaged UI tests; they do not prove the migrated
application's own workflows or every localization/resource configuration.

## What this does not cover

Test frameworks other than MSTest, test projects that are libraries rather than applications,
and custom test startup that the recipe does not recognize. That startup is left unchanged
and reported as needing a capability.

Writing, fixing or deleting tests. A test that fails after the host is migrated is a finding for
the app owner.

AppContainer test hosts, and any change to package identity, trust or machine policy.
