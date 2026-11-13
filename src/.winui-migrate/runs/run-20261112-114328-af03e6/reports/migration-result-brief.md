# Post-migration assessment brief


## Post-run controller result
Run `run-20261112-114328-af03e6`; task `01d4dc2cd28c409bababcba9fe4c0ab9`.
Status: Failed; acceptance: NotRun; stop: BaselineBroken; finalization: sealed.
Required checks: 0/124 passed; 0 failed; 0 blocked; 124 not run.
The working database is authoritative. Without a verified sibling manifest, a repository bundle and its reports are uncommitted candidates, not completed provenance.
Controller: 2 input captures (2 full, 0 incremental, 0 fallback), 1452 files hashed and 0 reused from 1452 observations, 38167834 bytes read, 1131 ms capture time; 1 ledger refreshes, 36 ms excluding capture.
Complete records: sibling migration-result.json and migration-result.md. This is not another pre-assessment.

## Remaining-work categories (all categories counted)
Pending execution: 124 required checks. Examples: ea0b2abcb05a5588, 4090f6e321fd4dab, f9b5396aebfa3f1d, 15f8b41eaa3f03c3.

## Reviewed package source configuration
Destination: `nuget.config`; SHA-256: `8ae8d19e861e4e2ab78ea9ea61cecbc420ba90278c5c602b87d0313348cde6c0`.
Proposal origin: `C:\Users\raghavmadan\.copilot\session-state\52f15054-86e8-4212-b97b-e50be2b17a1f\files\calculator-review\proposed-nuget.config`. The assessment contains the immutable configuration; the origin is not reread during execution.
Source declarations, disabled-source settings and mappings replace inherited source policy. Review every source and pattern. No credentials are embedded.
- nuget.org: `https://api.nuget.org/v3/index.json`; packages: none.
- azure-default: `https://packagefeedproxy.microsoft.io/nuget/v3/index.json`; packages: *.
After approval, the checked configuration action applies these bytes and records its patch. Feed lookup does not establish a complete application restore.

## Plan preview vs actual
Forecast vs actual: 0 of 11 forecast project actions ran (precision 0%); 0 of 0 applied project actions were forecast (coverage n/a). 46 forecast steps had no executor action to confirm them. The run stopped (BaselineBroken) before finishing, so precision is a lower bound.
predicted-not-run: (solution) RemoveUnsupportedXamlAttribute (forecast 1, attempted 0, applied 0).
predicted-not-run: Calculator.Tests\Calculator.Tests.csproj ReplaceNamespace (forecast 2, attempted 0, applied 0).
predicted-not-run: Calculator.ViewModels\Calculator.ViewModels.csproj AddUsingStatement (forecast 1, attempted 0, applied 0).
predicted-not-run: Calculator.ViewModels\Calculator.ViewModels.csproj MigrateSingleWindowApis (forecast 1, attempted 0, applied 0).
predicted-not-run: Calculator.ViewModels\Calculator.ViewModels.csproj ReplaceNamespace (forecast 4, attempted 0, applied 0).
predicted-not-run: CalculatorUITestFramework\CalculatorUITestFramework.csproj ReplaceNamespace (forecast 1, attempted 0, applied 0).
predicted-not-run: Calculator\Calculator.csproj AddUsingStatement (forecast 1, attempted 0, applied 0).
predicted-not-run: Calculator\Calculator.csproj MigrateSingleWindowApis (forecast 3, attempted 0, applied 0).
predicted-not-run: Calculator\Calculator.csproj MigrateUwpLifecycle (forecast 1, attempted 0, applied 0).
predicted-not-run: Calculator\Calculator.csproj MigrateXamlMaterial (forecast 2, attempted 0, applied 0).
predicted-not-run: Calculator\Calculator.csproj ReplaceNamespace (forecast 25, attempted 0, applied 0).

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
ea0b2abcb05a5588 CalcManager\CalcManager.vcxproj/build: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
4090f6e321fd4dab CalcManager\CalcManager.vcxproj/install-signed-package: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
a503260d6393a514 CalcManager\CalcManager.vcxproj/launch: NotRun; required=True; applicable=False. Not applicable under the reviewed 'app' scope.
f9b5396aebfa3f1d CalcManager\CalcManager.vcxproj/package: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
15f8b41eaa3f03c3 CalcManager\CalcManager.vcxproj/package-configuration: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
18c74e45f3737d12 CalcManager\CalcManager.vcxproj/prepare-environment: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
00df4bed28af2dbd CalcManager\CalcManager.vcxproj/retarget: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
e8c213638fa37073 CalcManager\CalcManager.vcxproj/runtime-compatibility: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
97e71deecc7b87b4 CalcManager\CalcManager.vcxproj/sign-package: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
fdbd56d0b36d206e CalcManager\CalcManager.vcxproj/smoke-test: NotRun; required=True; applicable=False. Not applicable under the reviewed 'script' scope.
aaca4c4fee05a5ec CalcManager\CalcManager.vcxproj/test: NotRun; required=True; applicable=False. Not applicable under the reviewed 'tests' scope.
88d22bd683487312 CalcManager\CalcManager.vcxproj/test-host-compatibility: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
43edc4e5cfedff32 CalcManager\CalcManager.vcxproj/windowing-compatibility: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
9e886dcb82e748f0 CalcManager.Interop\CalcManager.Interop.vcxproj/build: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
623951647ab9797b CalcManager.Interop\CalcManager.Interop.vcxproj/install-signed-package: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
b9e1d0601c5f3584 CalcManager.Interop\CalcManager.Interop.vcxproj/launch: NotRun; required=True; applicable=False. Not applicable under the reviewed 'app' scope.
439924855aacf9aa CalcManager.Interop\CalcManager.Interop.vcxproj/package: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
830f58ca0df3c6e8 CalcManager.Interop\CalcManager.Interop.vcxproj/package-configuration: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
de1e083b82f003c0 CalcManager.Interop\CalcManager.Interop.vcxproj/prepare-environment: NotRun; required=True; applicable=True. Not attempted: BaselineBroken
6445402960d7b9f9 CalcManager.Interop\CalcManager.Interop.vcxproj/retarget: NotRun; required=True; applicable=True. Not attempted: BaselineBroken

## Identity and evidence
Approved assessment `01d4dc2cd28c409bababcba9fe4c0ab9`, revision 2, hash `806679bc0bf2ffc13dde5e04a74c306671ba07a240baa330f5f95c05b3bdccb5`.
Input `92fb163850e2dbfe71179bfdd2d58627192d8b0a018f30ae3e811000c0d2318c`; final `92fb163850e2dbfe71179bfdd2d58627192d8b0a018f30ae3e811000c0d2318c`.
141 named component records; 6 events; 0 step/plan records.
Working database `C:\phase2\calculator-winui3\.winui-migrate\working\migration.db`; archive `C:\phase2\calculator-winui3\.winui-migrate\runs\run-20261112-114328-af03e6\manifest.json`.

## Audit gaps and limitations
Unreported token, currency, CPU and memory fields are unknown, not zero.
Process resources cover the direct child only, not its descendants or external agents.
Declaration checks do not establish runtime or semantic equivalence. No new coverage is inferred.
Hashes prove local consistency, not independent attestation. Review raw provenance before publishing.

## Review completeness
**DETAILS OMITTED; complete ledger remains in migration-result.json.**
The brief's item/size limits excluded entries; they were not removed from the assessment.
Extract only the named fields in bounded batches. Review omitted blockers, decisions, requirements and uncertainty; do not silently waive them.
- JSON `budgets`: 184 of 204 brief entries not shown.
- JSON `run.accountability.checks`: 137 of 157 brief entries not shown.
