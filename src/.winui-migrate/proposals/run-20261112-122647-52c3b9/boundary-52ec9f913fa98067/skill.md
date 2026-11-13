---
name: winui2-to-winui3-windowing
version: 0.2.4
owner: sachikumar@microsoft.com
description: Use when a build error names CoreWindow, ApplicationView, CoreApplicationView or a title bar type, and when auditing an app for Window.Current. In WinUI 3 a window is backed by a real window handle, the view concept is gone, and Window.Current still compiles but returns null at runtime. That last one is the highest-ranked source of null reference failures in these migrations and no build will catch it.
user-invocable: false
kind: repair
pack: uwp
verify: build, windowing-compatibility, launch
applies-to-diagnostic:
  - WINUI0006
  - WINUI0007
  - WINUI0011
---

# Windowing

Three related changes. The first two are ordinary ports. The third is the one that hurts.

A window is no longer built on a core window, and it is no longer tied to a single view per UI
thread. It is backed by a real window handle, and an app may have several windows on one thread.

The view type that carried window-level settings is replaced by an app window object that owns the
presenter, title bar, icon, position and size. This is a richer surface, so most of these ports gain
capability rather than losing it.

Then there is `Window.Current`. In UWP it was always populated, so helper code across the whole app
reached for it freely. **In WinUI 3 it compiles and returns null.** This is not a compile-time
removal. It is a runtime null, and it appears in whatever code path happened to call it, usually far
from anything that looks like windowing.

## Steps

1. Look up the window type, the app window type, and the way to get one from the other with
   `winui-migrate lookup`.

2. Do the `Window.Current` sweep first, before any other change in this area. Search the whole
   solution, including helper classes, base classes and anything that looks like a "current view"
   utility. This search is the entire mitigation, because nothing later will surface these.

3. For each hit, replace it with a window that was passed in or stored. The usual shape is to keep
   the window created at startup in a field and hand it to whatever needs it. Reaching for a global
   again, under a different name, reproduces the same problem with extra steps.

   Where a call site genuinely has no route to a window, report it. It normally means that code was
   relying on there being exactly one window, which is an assumption that no longer holds.

4. Replace the view type with the app window. Get it from the window rather than from a static
   accessor.

5. Port the title bar. The new surface is not a rename — it supports drag regions and caption
   buttons that the old one did not, and extending content into the title bar is a separate opt-in
   from customising it. Expect this to need real work rather than substitution.

6. Check every assumption of a single window. Code written when one thread meant one view often
   holds state that is really per window. This does not fail immediately; it fails the first time a
   second window exists.

7. If any code needs a window handle to pass to something else, that is a separate procedure. See
   `winui2-to-winui3-hwnd-interop`.

## Registered expression repair

`MigrateSingleWindowApis` revision 4 changes supported expressions, not entire classes or
application methods. It does not inject application namespaces, dependency resolvers, theme
policies, fixed title-bar dimensions or business logic.

The optional `window` parameter is an existing source reference. Otherwise the tool can infer
one unambiguous direct Window field/property, a Window parameter in the affected method, or `this`
in a Window subclass. Supplied expressions must resolve to supported typed declarations and valid
instance/static scope; an arbitrary expression is not proof of ownership. Establish that the reference
is initialized, has the correct type and belongs to the relevant UI thread. Missing/ambiguous
ownership, multiple affected classes and unsupported behavior remain explicit capability gaps.
Syntax checks reject locally shadowed framework names; they are not a full semantic compilation.

For a single recognized Application launch override whose current-window accesses are confined to
that override, the tool can establish an instance-owned Window before the existing startup work.
Application class/file names are discovered; no static MainWindow is invented. Activation paths that
need another initialization policy remain unsupported rather than implicitly becoming single-instance.
Opaque application members or custom creation expressions also prevent automatic window creation:
they may already own a derived Window. Such cases need an established ownership reference, not a
second window. This recipe does not redesign dependency-injection graphs or public constructor APIs.

Supported cases include `Window.Current`, direct current-view title/fullscreen queries,
title-bar colors through a current-view local used only for title/title-bar access, direct title-bar
extension assignments, and existing SetTitleBar drag-element calls against the bound window,
statement-only fullscreen transitions, and statement-only resize operations. Resize evaluates
the original Size expression once and converts DIP client dimensions using the owning HWND's DPI
before calling `AppWindow.ResizeClient`. Supported preferred-launch-size assignments become
operations on the bound window: use that recipe only when the existing startup ordering and
approved intent establish that this is the window being sized. It is not a general future-window
default policy.

Boolean-returning try operations used as values, custom title-bar layout/visibility event adapters and unsupported
presenters are not replaced by void statements or templates. Preserve those call sites.
Keyboard-state calls on `CoreWindow.GetForCurrentThread()` use
`InputKeyboardSource.GetKeyStateForCurrentThread`; they do not need a global window.

The pre-build evaluator reports `WINUI0006` (current window), `WINUI0007` (view/sizing),
`WINUI0010` (keyboard state), and `WINUI0011` (custom current-view behavior).
`WINUI0009` remains the separate UI-test cleanup diagnostic.

## Registered App.MainWindow ownership recipe

The `window-ownership-recipe` runs as a deterministic Recipe-tier planner after the windowing
compatibility evaluator. It applies only when the target has one `App.xaml.cs`/`App.cs` application
class with an `OnLaunched` override that creates the main WinUI `Window`. The executor action adds
or reuses `App.MainWindow`, assigns it immediately after the launch-created window is available,
and rewrites syntactic `Window.Current` uses in that target's C# files to `App.MainWindow`.

The recipe deliberately handles only exact, verified shapes: direct current-window member access,
`Window.Current.SetTitleBar(element)`,
`CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar` (read or written), which becomes
`App.MainWindow.ExtendsContentIntoTitleBar`, and `ApplicationView.GetForCurrentView().TitleBar` used
only for its colour properties (directly or through one local), which becomes
`App.MainWindow.AppWindow.TitleBar` (a declared `ApplicationViewTitleBar` local becomes
`AppWindowTitleBar`). Files that create their own `new Window()` or use secondary-view APIs are
treated as secondary-window owners and are left untouched, as is code whose type or member already
holds its own `Window`. Other current-view locals, presenter logic, custom title-bar events such as
`LayoutMetricsChanged`, ambiguous application startup, and any remaining evaluator findings stay
for the later model/agent tier.

## Bounded repair proposer recipe

When a reviewed `MissingCapability` group is handed to the bounded read-only repair proposer,
the skill is the technical recipe and the controller profile is only the safety contract.
Investigate the application window creation and activation path, XAML construction, current-view
helper consumers, project-reference direction, service lifetimes, UI-thread access, title-bar usage,
tests, and instancing assumptions. Do not invent globals, dependency injection, ownership,
lifetime, window-count, packaging, identity, activation, or lifecycle policy.

When controller requirements name "the primary application window", that singular window is the
approved owner for the stated scenario. When they require window close to await asynchronous
persistence, the standard guarded `AppWindow.Closing` implementation may cancel the first close,
await the required work, and close exactly once afterward; that sequencing is implementation, not a
new product policy. Reuse existing ownership and dependency-registration paths instead of adding a
new global. Existing window/view helper types keep their caller-facing operations but implement
them with `Window.AppWindow` and presenters. Reuse the existing dependency-registration/resolver
path when readable call sites show one; complete readable wrapper and module call sites are
sufficient evidence for preserving calls made through an existing resolver. Existing
`RegisterSingleton<T>` and `Resolve<T>` call shapes may carry the retained app-owned `Window`
without reading the resolver interface or implementation. If either resolver path is denied, do not
retry it, cite it, or make it a prerequisite. Treat excluded internals as opaque and unchanged.
Do not reject a candidate solely because they are unavailable.
When the readable wrapper constructs the resolver once and readable module registration already
uses the required generic call shape, adding one `Window` registration in that same one-time
initialization path does not require assumptions about duplicate registration or hidden lifetime
behavior. The build and evaluators verify signature compatibility afterward.

Prefer this bounded implementation shape when the staged files and requirements support it:
the application retains one `Window`, initializes the existing resolver with it before resolving
services, and registers it as the documented singleton; platform/environment helper types use
`DispatcherQueue` for UI-thread detection; window-dependent services receive or resolve that
`Window`; use `AppWindow.SetPresenter` directly and close through the retained `Window.Close`
method. Do not use nonexistent `AppWindowPresenter.IsPresentationSupported`,
`CompactOverlayPresenter.IsSupported`, or `AppWindow.Close` members. Compact overlay is selected
directly with `AppWindow.SetPresenter(AppWindowPresenterKind.CompactOverlay)`; do not invent a
support-query API. Unsupported spanning states remain inactive; the custom title bar uses
`Window.SetTitleBar`, `AppWindow.TitleBar` and `AppWindow.Changed`; removed suspension handlers
become guarded close preparation methods invoked before the first close is allowed to complete.

Desktop share APIs are also window-owned. `DataTransferManager.GetForCurrentView` and the static
`DataTransferManager.ShowShareUI` overloads are UWP-only and must not remain. Pass or resolve the
retained `Window` through the existing construction path. Obtain its HWND with
`WinRT.Interop.WindowNative.GetWindowHandle(window)`. Use the documented
`IDataTransferManagerInterop` COM interface (GUID `3A3DCD6C-3EAB-43DC-BCDE-45671CE800C8`):
call `GetForWindow` with the `DataTransferManager` IID
`A5CAEE9B-8708-49D1-8D36-67D25A8DA00C`, marshal the returned ABI pointer to
`DataTransferManager`, and invoke `ShowShareUIForWindow` for that same HWND. Preserve the existing
`DataRequested` subscription and share payload behavior. Do not use a static current view, invent
another window, or defer manager creation until after the share request.

`Windows.System.DispatcherQueue` and `DispatcherQueueTimer` belong to the UWP view model and can
return null in this desktop process even though they compile. Use the corresponding
`Microsoft.UI.Dispatching` types. Keep unrelated `Windows.System` APIs imported when the file still
uses them; qualify the dispatcher types instead of replacing the whole namespace.

## Checking it worked

When a newly checkpointed `MissingCapability` run needs a constructor/owner propagation that the
registered expression action cannot express, an explicitly requested `repair propose` can prepare
one exact source candidate using this skill. Include the actual owner, consumers and relevant
construction paths in its bounded source scope. Existing ownership and window count are constraints,
not choices to invent. Unknown dynamic factories, DI lifetimes or missing source require handoff.
Do not prescribe an `IWindowContext` interface, static accessor or application-specific namespace.
Review the candidate's full diff and obtain its exact hash approval before `repair apply`.
Static validation only is available before approval; continue to perform the checks below.

The build errors naming the removed types are gone, and a search for `Window.Current` returns
nothing outside comments.

The search is the check that matters. A build passing here proves almost nothing, because the null
is a runtime value.

Then open the app and use it normally, including any path that shows a second window. Null reference
failures from this change tend to appear on secondary paths, not on startup.

If the title bar was customised, check it in both light and dark themes, and check that the window
can still be dragged. A custom title bar with no drag region looks correct and cannot be moved.

## What this does not cover

Deciding how many windows the app should have. Multiple windows are now possible, and that is a
design opportunity, but it is not part of migrating.

Anything that needs a window handle in order to call something else, which is
`winui2-to-winui3-hwnd-interop`.
