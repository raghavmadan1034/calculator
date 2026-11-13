# Post-migration assessment brief


## Post-run controller result
Run `run-20261112-115854-cf4fd8`; task `c9b8be164e984ceeb602f36e1648e91c`.
Status: Failed; acceptance: Fail; stop: MissingCapability; finalization: sealed.
Required checks: 114/124 passed; 6 failed; 1 blocked; 3 not run.
The working database is authoritative. Without a verified sibling manifest, a repository bundle and its reports are uncommitted candidates, not completed provenance.
Controller: 385 input captures (385 full, 0 incremental, 0 fallback), 279510 files hashed and 0 reused from 279510 observations, 7347011430 bytes read, 221688 ms capture time; 186 ledger refreshes, 7054 ms excluding capture.
Complete records: sibling migration-result.json and migration-result.md. This is not another pre-assessment.

## Remaining-work categories (all categories counted)
Execution or criterion blocked: 1 required checks. Examples: 87582096903996eb.
Observed failure: 6 required checks. Examples: 2d2689a322c7e19e, ab7ab6a2263e8671, 0c3ee63d3728df10, ee64a7888c26ea2a.
Pending execution: 3 required checks. Examples: 0fa0c5d5cb290240, 7969543de78c11e7, b8cd9c7a088f8edc.

## Reviewed package source configuration
Destination: `nuget.config`; SHA-256: `8ae8d19e861e4e2ab78ea9ea61cecbc420ba90278c5c602b87d0313348cde6c0`.
Proposal origin: `C:\Users\raghavmadan\.copilot\session-state\52f15054-86e8-4212-b97b-e50be2b17a1f\files\calculator-review\proposed-nuget.config`. The assessment contains the immutable configuration; the origin is not reread during execution.
Source declarations, disabled-source settings and mappings replace inherited source policy. Review every source and pattern. No credentials are embedded.
- nuget.org: `https://api.nuget.org/v3/index.json`; packages: none.
- azure-default: `https://packagefeedproxy.microsoft.io/nuget/v3/index.json`; packages: *.
After approval, the checked configuration action applies these bytes and records its patch. Feed lookup does not establish a complete application restore.

## Plan preview vs actual
Forecast vs actual: 3 of 11 forecast project actions ran (precision 27%); 3 of 3 applied project actions were forecast (coverage 100%). 46 forecast steps had no executor action to confirm them. The run stopped (MissingCapability) before finishing, so precision is a lower bound.
predicted-not-run: (solution) RemoveUnsupportedXamlAttribute (forecast 1, attempted 0, applied 0).
predicted-not-run: Calculator.ViewModels\Calculator.ViewModels.csproj AddUsingStatement (forecast 1, attempted 0, applied 0).
predicted-not-run: Calculator.ViewModels\Calculator.ViewModels.csproj MigrateSingleWindowApis (forecast 1, attempted 1, applied 0).
predicted-not-run: Calculator.ViewModels\Calculator.ViewModels.csproj ReplaceNamespace (forecast 3, attempted 0, applied 0).
predicted-not-run: CalculatorUITestFramework\CalculatorUITestFramework.csproj ReplaceNamespace (forecast 1, attempted 0, applied 0).
predicted-not-run: Calculator\Calculator.csproj AddUsingStatement (forecast 1, attempted 0, applied 0).
predicted-not-run: Calculator\Calculator.csproj MigrateSingleWindowApis (forecast 3, attempted 8, applied 0).
predicted-not-run: Calculator\Calculator.csproj MigrateUwpLifecycle (forecast 1, attempted 0, applied 0).

## Budget allocation and usage
attempts:ea0b2abcb05a5588 / CalcManager\CalcManager.vcxproj/build: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:4090f6e321fd4dab / CalcManager\CalcManager.vcxproj/install-signed-package: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:a503260d6393a514 / CalcManager\CalcManager.vcxproj/launch: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:f9b5396aebfa3f1d / CalcManager\CalcManager.vcxproj/package: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:15f8b41eaa3f03c3 / CalcManager\CalcManager.vcxproj/package-configuration: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:18c74e45f3737d12 / CalcManager\CalcManager.vcxproj/prepare-environment: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:00df4bed28af2dbd / CalcManager\CalcManager.vcxproj/retarget: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:e8c213638fa37073 / CalcManager\CalcManager.vcxproj/runtime-compatibility: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:97e71deecc7b87b4 / CalcManager\CalcManager.vcxproj/sign-package: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:fdbd56d0b36d206e / CalcManager\CalcManager.vcxproj/smoke-test: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:aaca4c4fee05a5ec / CalcManager\CalcManager.vcxproj/test: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:88d22bd683487312 / CalcManager\CalcManager.vcxproj/test-host-compatibility: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:43edc4e5cfedff32 / CalcManager\CalcManager.vcxproj/windowing-compatibility: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:9e886dcb82e748f0 / CalcManager.Interop\CalcManager.Interop.vcxproj/build: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:623951647ab9797b / CalcManager.Interop\CalcManager.Interop.vcxproj/install-signed-package: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:b9e1d0601c5f3584 / CalcManager.Interop\CalcManager.Interop.vcxproj/launch: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:439924855aacf9aa / CalcManager.Interop\CalcManager.Interop.vcxproj/package: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:830f58ca0df3c6e8 / CalcManager.Interop\CalcManager.Interop.vcxproj/package-configuration: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:de1e083b82f003c0 / CalcManager.Interop\CalcManager.Interop.vcxproj/prepare-environment: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.
attempts:6445402960d7b9f9 / CalcManager.Interop\CalcManager.Interop.vcxproj/retarget: limit 10, used 0, remaining 10 executions; hard; Started executions, including interrupted attempts; invalidation does not reset usage.

## Check details
ea0b2abcb05a5588 CalcManager\CalcManager.vcxproj/build: Pass; required=True; applicable=True. msbuild built CalcManager.vcxproj in 1.3s.
4090f6e321fd4dab CalcManager\CalcManager.vcxproj/install-signed-package: Pass; required=True; applicable=True. No signed-package install check requested.
a503260d6393a514 CalcManager\CalcManager.vcxproj/launch: NotRun; required=True; applicable=False. Not applicable under the reviewed 'app' scope.
f9b5396aebfa3f1d CalcManager\CalcManager.vcxproj/package: Pass; required=True; applicable=True. Native packaging selected; WinApp created no package.
15f8b41eaa3f03c3 CalcManager\CalcManager.vcxproj/package-configuration: Pass; required=True; applicable=True. The exact approved package source configuration is present.
18c74e45f3737d12 CalcManager\CalcManager.vcxproj/prepare-environment: Pass; required=True; applicable=True. Native environment preparation selected; WinApp made no changes.
00df4bed28af2dbd CalcManager\CalcManager.vcxproj/retarget: Pass; required=True; applicable=True. CalcManager.vcxproj is already in the shape the migration wants.
e8c213638fa37073 CalcManager\CalcManager.vcxproj/runtime-compatibility: Pass; required=True; applicable=True. No known compile-clean runtime compatibility hazards were found.
97e71deecc7b87b4 CalcManager\CalcManager.vcxproj/sign-package: Pass; required=True; applicable=True. No development signing requested; the MSIX stays unsigned.
fdbd56d0b36d206e CalcManager\CalcManager.vcxproj/smoke-test: NotRun; required=True; applicable=False. Not applicable under the reviewed 'script' scope.
aaca4c4fee05a5ec CalcManager\CalcManager.vcxproj/test: NotRun; required=True; applicable=False. Not applicable under the reviewed 'tests' scope.
88d22bd683487312 CalcManager\CalcManager.vcxproj/test-host-compatibility: Pass; required=True; applicable=True. No legacy test bootstrap found.
43edc4e5cfedff32 CalcManager\CalcManager.vcxproj/windowing-compatibility: Pass; required=True; applicable=True. No UWP-only window access patterns were found.
9e886dcb82e748f0 CalcManager.Interop\CalcManager.Interop.vcxproj/build: Pass; required=True; applicable=True. msbuild built CalcManager.Interop.vcxproj in 3s with 1 warning.
623951647ab9797b CalcManager.Interop\CalcManager.Interop.vcxproj/install-signed-package: Pass; required=True; applicable=True. No signed-package install check requested.
b9e1d0601c5f3584 CalcManager.Interop\CalcManager.Interop.vcxproj/launch: NotRun; required=True; applicable=False. Not applicable under the reviewed 'app' scope.
439924855aacf9aa CalcManager.Interop\CalcManager.Interop.vcxproj/package: Pass; required=True; applicable=True. Native packaging selected; WinApp created no package.
830f58ca0df3c6e8 CalcManager.Interop\CalcManager.Interop.vcxproj/package-configuration: Pass; required=True; applicable=True. The exact approved package source configuration is present.
de1e083b82f003c0 CalcManager.Interop\CalcManager.Interop.vcxproj/prepare-environment: Pass; required=True; applicable=True. Native environment preparation selected; WinApp made no changes.
6445402960d7b9f9 CalcManager.Interop\CalcManager.Interop.vcxproj/retarget: Pass; required=True; applicable=True. CalcManager.Interop.vcxproj is already in the shape the migration wants.

## Identity and evidence
Approved assessment `c9b8be164e984ceeb602f36e1648e91c`, revision 2, hash `9b5866c1cc87a31fde0697467355fe88e8c81b5a9d35319fa15f1d5361a003c5`.
Input `01a0a0c6c8d20f9f0cde04ac1390843f8c5c61c34a74eb9b704009c9bd95dcf9`; final `03a4c4514d040ccebe1c144e41cc38b285d47c97128c05b1e01ca34da0c65013`.
178 named component records; 1287 events; 86 step/plan records.
Working database `C:\phase2\calculator-winui3\.winui-migrate\working\migration.db`; archive `C:\phase2\calculator-winui3\.winui-migrate\runs\run-20261112-115854-cf4fd8\manifest.json`.

## Audit gaps and limitations
Unreported token, currency, CPU and memory fields are unknown, not zero.
Process resources cover the direct child only, not its descendants or external agents.
Declaration checks do not establish runtime or semantic equivalence. No new coverage is inferred.
Hashes prove local consistency, not independent attestation. Review raw provenance before publishing.

## Review completeness
**DETAILS OMITTED; complete ledger remains in migration-result.json.**
The brief's item/size limits excluded entries; they were not removed from the assessment.
Extract only the named fields in bounded batches. Review omitted blockers, decisions, requirements and uncertainty; do not silently waive them.
- JSON `budgets`: 282 of 302 brief entries not shown.
- JSON `run.accountability.checks`: 137 of 157 brief entries not shown.
