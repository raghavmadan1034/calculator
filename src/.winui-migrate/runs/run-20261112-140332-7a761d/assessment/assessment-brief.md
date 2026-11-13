# Migration assessment review brief


## Assessment
Assessment `e3301c2c49e9493692621538e95ab437`, revision 2
Approval hash: `b4e94b66c7d978cfa034e8d8882984406f76518d9804ba65a98305ec40da260f`
This bounded review is approval-ready. Full exact evidence remains in sibling assessment.json and assessment.md.
For omitted informational detail, inspect one named field only on demand. Page through the complete stage inventory before approval.
Approval authorizes the reviewed direction, not proof of compatibility. Requirements bind; preferences steer.
No application copy, restore, build, launch or tests were executed by this assessment.
12 projects; 5089 API/control findings; 451 identifiable test declarations (inventory, not coverage).

## Approved execution contract
Policy required-evidence-v2; 123 required checks.
Availability does not change this denominator. Missing evidence is not a pass.
Waiving checks or changing limits requires an explicitly approved new revision.

## Reviewed stage inventory
123 numbered stages; 33 separate exclusions. Plan hash: 0fadb9a9906c3da127035e0a04a86b459db50be28a6a4ba106e1ffaa53aba60d.
Inspect every page before approval: winui-migrate progress plan --assessment <exact assessment.json path>.
Preparation and finalization remain outside the counter. Stage position is not an acceptance verdict.

## Scope and destination
Source: `C:\phase2\calculator-winui3`
Workspace: `C:\phase2\calculator-winui3`
Storage: Active database: C:\phase2\calculator-winui3\.winui-migrate\working\migration.db. Created only after approval; per-run snapshots and evidence remain in this repository. Working state is Git-ignored; publishing unredacted snapshots requires privacy review.
Target: `C:\phase2\calculator-winui3\Calculator.slnx`
Mode: in-place: edits the input.
Every-project: True; plan-only: False; round limit per target/evaluator: 10.
Reasoning: allowed if available.
Framework: Per-project converter target; see projects.
Packaging: Existing converter defaults; runtime identity must be verified.
Replay: none

## Blocking review issues
None recorded. This is not proof of compatibility.

## Decisions to answer: 9 (5 not doable, 3 decision required, 1 unknown; 0 unanswered)
- D1 not-doable, source CalcManager (1 use): The project cannot be migrated: C++ project, not something this tool can migrate Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D2 not-doable, source CalculatorUnitTests (1 use): The project cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D3 not-doable, source GraphControl (1 use): The project cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D4 not-doable, source GraphingImpl (1 use): The project cannot be migrated: C++ project, not something this tool can migrate Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D5 not-doable, source TraceLogging (1 use): The project cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D6 decision-required, api ApplicationData (17 uses): WinUI 3 has no drop-in replacement. Returns null/throws when unpackaged. Use Environment.SpecialFolder.LocalApplicationData (Win32). Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity.
- D7 decision-required, api Windows.Storage.ApplicationData (2 uses): WinUI 3 has no drop-in replacement. Returns null/throws when unpackaged. Use Environment.SpecialFolder.LocalApplicationData (Win32). Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity.
- D8 decision-required, api Windows.UI.Xaml.Controls.Pivot (1 use): WinUI 3 has no drop-in replacement. Not ported, by design, and it is not coming back. SelectorBar is the segmented replacement; TabView is the one for tabbed documents. Neither is a drop-in. Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-control-parity-triage [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-control-parity-triage.
- D9 unknown, package MSTest (1 use): No rule in dependency-rules.tsv classifies it. Options: defer, exclude-scope. Answered: defer.
- The loop acts on the answers when a build error names the subject: the recommended option keeps the rule's repair, another option rules it out for a person or the model, defer stops to ask, and exclude-scope leaves it unchanged.

## Next step
- Approve this revision and start the migration: `winui-migrate migrate --assessment "C:\Users\raghavmadan\.copilot\session-state\52f15054-86e8-4212-b97b-e50be2b17a1f\files\calculator-review\assessments\e3301c2c49e9493692621538e95ab437\revisions\0002-b4e94b66c7d9\assessment.json" --approve b4e94b66c7d978cfa034e8d8882984406f76518d9804ba65a98305ec40da260f`
- Or change direction with `--feedback <json>`. At the interactive prompt: approve, reject, answer D1=a, or feedback <json>.

## Readiness scores (source queries, not verified)
- Verdict: Feasibility 58.3 / 100, NO, 5 blockers, no high-risk areas, not fully assessed: dependency_closure.
- EVAL-01 source_completeness: coverage 100.0%, feasibility 58.3%, risk blocker.
- EVAL-02 control_compatibility: coverage 100.0%, feasibility 100.0%, risk low.
- EVAL-03 managed_api_compatibility: coverage 100.0%, feasibility 100.0%, risk low.
- EVAL-04 dependency_closure: coverage 92.9%, feasibility 92.9%, risk medium.
- EVAL-05 native_interop_coverage: coverage 100.0%, feasibility 100.0%, risk medium.
- EVAL-06 runtime_path_coverage: coverage 100.0%, feasibility 100.0%, risk medium.
- EVAL-07 behavioral_coverage: coverage 100.0%, feasibility 100.0%.
- EVAL-08 build_matrix_coverage: coverage 100.0%, feasibility 100.0%.
- Controls and members were looked up in Microsoft.WindowsAppSDK 2.6.5 (Microsoft.WindowsAppSDK.WinUI 2.6.5) and Windows SDK 10.0.26100.0.

## Blocker and high-risk items
- EVAL-01 blocker: Project CalcManager cannot be migrated: C++ project, not something this tool can migrate
- EVAL-01 blocker: Project CalculatorUnitTests cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out
- EVAL-01 blocker: Project GraphControl cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out
- EVAL-01 blocker: Project GraphingImpl cannot be migrated: C++ project, not something this tool can migrate
- EVAL-01 blocker: Project TraceLogging cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out

## Plan preview (forecast, nothing changed): 47 steps in 10 projects: 18 automatic, 6 check at runtime, 11 assisted, 6 decision required, 5 not doable, 1 unknown
- `CalcManager.Interop.vcxproj`: 1 assisted.
- `CalcManager.vcxproj`: 1 not doable (governed by D1).
- `Calculator.Tests.csproj`: 1 automatic, 2 assisted, 1 decision required, 1 unknown (governed by D6, D9).
- `Calculator.ViewModels.csproj`: 3 automatic, 1 check at runtime, 4 assisted, 3 decision required (governed by D6, D7).
- `Calculator.csproj`: 13 automatic, 5 check at runtime, 4 assisted, 2 decision required (governed by D6, D8).
- `CalculatorUITestFramework.csproj`: 1 automatic.
- `CalculatorUnitTests.vcxproj`: 1 not doable (governed by D2).
- `GraphControl.vcxproj`: 1 not doable (governed by D3).
- `GraphingImpl.vcxproj`: 1 not doable (governed by D4).
- `TraceLogging.vcxproj`: 1 not doable (governed by D5).
- A forecast: the loop still plans each round from the build, and errors only the retargeted build reveals are not predicted.
- 329 XAML references to platform elements keep their markup: WinUI 3 uses the same presentation namespace.
- 81 references to WinUI 2 names keep their spelling: WinUI 3 declares them in the same Microsoft.UI.Xaml namespaces.
- 4229 references have no dictionary entry and are expected to carry over unchanged; the build decides.
- 335 XAML references to app or third-party namespaces are not forecast.

## Planned steps a person, the model or a runtime check carries
- `Calculator.ViewModels.csproj` assisted, code: Windows.UI.Core (4 uses)
- `Calculator.csproj` assisted, code: Windows.UI.Core (4 uses)
- `CalcManager.Interop.vcxproj` assisted, project: CalcManager.Interop.vcxproj (1 use)
- `Calculator.Tests.csproj` assisted, code: Microsoft.VisualStudio.TestPlatform.TestExecutor (1 use)
- `Calculator.Tests.csproj` assisted, code: RunAsync (1 use)
- `Calculator.ViewModels.csproj` assisted, code: ApplicationView (1 use)
- `Calculator.ViewModels.csproj` assisted, code: CoreDispatcher (1 use)
- `Calculator.ViewModels.csproj` assisted, code: RunAsync (1 use)
- `Calculator.csproj` assisted, code: IActivatedEventArgs (1 use)
- `Calculator.csproj` assisted, code: Microsoft.UI.Xaml.Input.KeyboardAccelerator (1 use)
- `Calculator.csproj` assisted, code: Window (1 use)
- `Calculator.csproj` check-at-runtime, code: ShowAt (5 uses)
- `Calculator.csproj` check-at-runtime, code: Windows.ApplicationModel.Package.Current (5 uses)
- `Calculator.csproj` check-at-runtime, code: Popup (3 uses)
- `Calculator.ViewModels.csproj` check-at-runtime, code: CoreWindow (1 use)
- `Calculator.csproj` check-at-runtime, code: CoreApplication (1 use)
- `Calculator.csproj` check-at-runtime, code: Microsoft.UI.Xaml.Controls.ContentDialog (1 use)

## Proposed package source configuration (not applied)
Destination: `nuget.config`; SHA-256: `8ae8d19e861e4e2ab78ea9ea61cecbc420ba90278c5c602b87d0313348cde6c0`.
Proposal origin: `C:\Users\raghavmadan\.copilot\session-state\52f15054-86e8-4212-b97b-e50be2b17a1f\files\calculator-review\proposed-nuget.config`. The assessment contains the immutable configuration; the origin is not reread during execution.
Source declarations, disabled-source settings and mappings replace inherited source policy. Review every source and pattern. No credentials are embedded.
- nuget.org: `https://api.nuget.org/v3/index.json`; packages: none.
- azure-default: `https://packagefeedproxy.microsoft.io/nuget/v3/index.json`; packages: *.
After approval, the checked configuration action applies these bytes and records its patch. Feed lookup does not establish a complete application restore.

## Human requirements and preferences
None recorded. This is not proof of compatibility.

## Feedback interpretation
None recorded. This is not proof of compatibility.

## Changes since previous revision
- D1 CalcManager: answered exclude-scope.
- D2 CalculatorUnitTests: answered exclude-scope.
- D3 GraphControl: answered exclude-scope.
- D4 GraphingImpl: answered exclude-scope.
- D5 TraceLogging: answered exclude-scope.
- D6 ApplicationData: answered (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity.
- D7 Windows.Storage.ApplicationData: answered (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity.
- D8 Windows.UI.Xaml.Controls.Pivot: answered (a) Rework it as the dictionary note directs, using winui2-to-winui3-control-parity-triage.
- D9 MSTest: answered defer.

## Effective budgets (not yet consumed)
Input invalidation rechecks: 12 allocation(s); limit 10 rechecks; hard.
Repair attempts by evaluator: 156 allocation(s); limit 10 executions; hard.
Reviewed capability proposal: 2 allocation(s); limit 131,072-8,388,608 UTF-8 bytes; hard, hard; no truncation.

## Review completeness
**FOCUSED REVIEW REQUIRED before requesting approval.**
The brief's item/size limits excluded entries; they were not removed from the assessment.
Extract only the named fields in bounded batches. Review omitted blockers, decisions, requirements and uncertainty; do not silently waive them.
- JSON `contract.budgets`: 30 of 33 brief entries not shown.
- JSON `contract.checks`: 13 of 13 brief entries not shown.
- JSON `request.prepareRepairOnMissingCapability`: 3 of 3 brief entries not shown.
- JSON `gaps`: 6 of 6 brief entries not shown.
- JSON `projects`: 12 of 12 brief entries not shown.
- JSON `findings`: 13 of 13 brief entries not shown.
- JSON `coverage, request.smokeTestScript`: 6 of 6 brief entries not shown.
- JSON `inheritedInputs, workspaceInheritedInputs`: 1 of 1 brief entries not shown.
