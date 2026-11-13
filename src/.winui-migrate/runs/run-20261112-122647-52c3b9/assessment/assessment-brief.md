# Migration assessment review brief


## Assessment
Assessment `e8415e1a4dda4bb98cbc58609d719d4c`, revision 2
Approval hash: `5eb27167ad39eba6c752aad9526c5a1d915df3b0eb6d851d8539fde97f6b1ae3`
This bounded review is approval-ready. Full exact evidence remains in sibling assessment.json and assessment.md.
For omitted informational detail, inspect one named field only on demand. Page through the complete stage inventory before approval.
Approval authorizes the reviewed direction, not proof of compatibility. Requirements bind; preferences steer.
No application copy, restore, build, launch or tests were executed by this assessment.
12 projects; 5096 API/control findings; 451 identifiable test declarations (inventory, not coverage).

## Approved execution contract
Policy required-evidence-v2; 124 required checks.
Availability does not change this denominator. Missing evidence is not a pass.
Waiving checks or changing limits requires an explicitly approved new revision.

## Reviewed stage inventory
123 numbered stages; 33 separate exclusions. Plan hash: e7a672e22c20c10ed5ef37675ca5c3f9d55d11f8e17b967cf4d6452a5cdea96c.
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

## Decisions to answer: 14 (5 not doable, 8 decision required, 1 unknown; 0 unanswered)
- D1 not-doable, source CalcManager (1 use): The project cannot be migrated: C++ project, not something this tool can migrate Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D2 not-doable, source CalculatorUnitTests (1 use): The project cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D3 not-doable, source GraphControl (1 use): The project cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D4 not-doable, source GraphingImpl (1 use): The project cannot be migrated: C++ project, not something this tool can migrate Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D5 not-doable, source TraceLogging (1 use): The project cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D6 decision-required, xaml-member BackdropMaterial.ApplyToRootOrPageBackground (1 use): It is declared by no metadata that was read: Microsoft.UI.Xaml.Controls.BackdropMaterial is absent from WinUI 3 and the Windows SDK. Options: (a) Remove the attached property; the page keeps its authored background [remove] [recommended]; (b) Remove the attached property and set Window.SystemBackdrop to a MicaBackdrop on the window that hosts the page [replace]; defer, exclude-scope. Answered: (a) Remove the attached property; the page keeps its authored background.
- D7 decision-required, api ApplicationData (17 uses): WinUI 3 has no drop-in replacement. Returns null/throws when unpackaged. Use Environment.SpecialFolder.LocalApplicationData (Win32). Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity.
- D8 decision-required, api Suspending (2 uses): WinUI 3 has no drop-in replacement. Deferral-only subscriptions have a checked removal. Meaningful application work must remain until a source-grounded desktop trigger is established. The window-close recipe preserves and awaits existing work only under an applicable approved lifecycle requirement. Options: (a) Keep the suspension work and run it on the primary window's first close request: cancel that close, await the work, then close the window once (winui2-to-winui3-lifecycle) [replace] [requires desktop-lifecycle=window-close] [recommended]; (b) Move the suspension work to another desktop trigger the owner chooses, such as an explicit save or a change of window visibility (winui2-to-winui3-lifecycle) [replace]; defer, exclude-scope. Answered: (a) Keep the suspension work and run it on the primary window's first close request: cancel that close, await the work, then close the window once (winui2-to-winui3-lifecycle).
- D9 decision-required, api SystemNavigationManager (2 uses): WinUI 3 has no drop-in replacement. The shell back button is gone with no replacement. Back has to be built per window, normally the NavigationView back button or a title bar control. Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-windowing [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-windowing.
- D10 decision-required, api Windows.Storage.ApplicationData (2 uses): WinUI 3 has no drop-in replacement. Returns null/throws when unpackaged. Use Environment.SpecialFolder.LocalApplicationData (Win32). Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity.
- D11 decision-required, api Windows.UI.Xaml.Controls.Pivot (1 use): WinUI 3 has no drop-in replacement. Not ported, by design, and it is not coming back. SelectorBar is the segmented replacement; TabView is the one for tabbed documents. Neither is a drop-in. Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-control-parity-triage [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-control-parity-triage.
- D12 decision-required, runtime-path ResourceContext.GetForCurrentView (1 use): It compiles and then behaves differently: current-view resource qualifiers differ in MRT Core. Options: (a) Choose an MRT Core context and preserve every qualifier the app reads or writes [recommended]; defer, exclude-scope. Answered: (a) Choose an MRT Core context and preserve every qualifier the app reads or writes.
- D13 decision-required, runtime-path SystemNavigationManager.GetForCurrentView (2 uses): It compiles and then behaves differently: the UWP system back button has no desktop current view. Options: (a) Use existing in-app navigation or an owning-window back affordance [recommended]; defer, exclude-scope. Answered: (a) Use existing in-app navigation or an owning-window back affordance.
- D14 unknown, package MSTest (1 use): No rule in dependency-rules.tsv classifies it. Options: defer, exclude-scope. Answered: defer.
- The loop acts on the answers when a build error names the subject: the recommended option keeps the rule's repair, another option rules it out for a person or the model, defer stops to ask, and exclude-scope leaves it unchanged.

## Next step
- Approve this revision and start the migration: `winui-migrate migrate --assessment "C:\Users\raghavmadan\.copilot\session-state\52f15054-86e8-4212-b97b-e50be2b17a1f\files\calculator-review\assessments\e8415e1a4dda4bb98cbc58609d719d4c\revisions\0002-5eb27167ad39\assessment.json" --approve 5eb27167ad39eba6c752aad9526c5a1d915df3b0eb6d851d8539fde97f6b1ae3`
- Or change direction with `--feedback <json>`. At the interactive prompt: approve, reject, answer D1=a, or feedback <json>.

## Readiness scores (source queries, not verified)
- Verdict: Feasibility 58.3 / 100, NO, 5 blockers, 2 high-risk areas (control_compatibility, runtime_path_coverage), not fully assessed: dependency_closure.
- EVAL-01 source_completeness: coverage 100.0%, feasibility 58.3%, risk blocker.
- EVAL-02 control_compatibility: coverage 100.0%, feasibility 98.5%, risk high.
- EVAL-03 managed_api_compatibility: coverage 100.0%, feasibility 100.0%, risk low.
- EVAL-04 dependency_closure: coverage 92.9%, feasibility 92.9%, risk medium.
- EVAL-05 native_interop_coverage: coverage 100.0%, feasibility 100.0%, risk low.
- EVAL-06 runtime_path_coverage: coverage 100.0%, feasibility 100.0%, risk high.
- EVAL-07 behavioral_coverage: coverage 100.0%, feasibility 100.0%.
- EVAL-08 build_matrix_coverage: coverage 100.0%, feasibility 100.0%.
- Controls and members were looked up in Microsoft.WindowsAppSDK 2.6.5 (Microsoft.WindowsAppSDK.WinUI 2.6.5) and Windows SDK 10.0.26100.0.

## Blocker and high-risk items
- EVAL-01 blocker: Project CalcManager cannot be migrated: C++ project, not something this tool can migrate
- EVAL-01 blocker: Project CalculatorUnitTests cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out
- EVAL-01 blocker: Project GraphControl cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out
- EVAL-01 blocker: Project GraphingImpl cannot be migrated: C++ project, not something this tool can migrate
- EVAL-01 blocker: Project TraceLogging cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out
- EVAL-02 high: XAML member BackdropMaterial.ApplyToRootOrPageBackground (1 use) is declared by no metadata that was read; it needs a redesign decision.
- EVAL-06 high: Runtime path ResourceContext.GetForCurrentView needs a decision: current-view resource qualifiers differ in MRT Core. Alternative: choose an MRT Core context and preserve every qualifier the app reads or writes
- EVAL-06 high: Runtime path SystemNavigationManager.GetForCurrentView needs a decision: the UWP system back button has no desktop current view. Alternative: use existing in-app navigation or an owning-window back affordance

## Plan preview (forecast, nothing changed): 67 steps in 11 projects: 24 automatic, 11 check at runtime, 15 assisted, 11 decision required, 5 not doable, 1 unknown
- `CalcManager.Interop.vcxproj`: 1 assisted.
- `CalcManager.vcxproj`: 1 not doable (governed by D1).
- `Calculator.Tests.csproj`: 1 automatic, 2 assisted, 1 decision required, 1 unknown (governed by D7, D14).
- `Calculator.ViewModels.csproj`: 5 automatic, 3 check at runtime, 5 assisted, 4 decision required (governed by D7, D10, D12).
- `Calculator.csproj`: 17 automatic, 8 check at runtime, 7 assisted, 5 decision required (governed by D7, D8, D9, D11, D13).
- `CalculatorUITestFramework.csproj`: 1 automatic.
- `CalculatorUnitTests.vcxproj`: 1 not doable (governed by D2).
- `GraphControl.vcxproj`: 1 not doable (governed by D3).
- `GraphingImpl.vcxproj`: 1 not doable (governed by D4).
- `TraceLogging.vcxproj`: 1 not doable (governed by D5).
- `(solution)`: 1 decision required (governed by D6).
- A forecast: the loop still plans each round from the build, and errors only the retargeted build reveals are not predicted.
- 329 XAML references to platform elements keep their markup: WinUI 3 uses the same presentation namespace.
- 81 references to WinUI 2 names keep their spelling: WinUI 3 declares them in the same Microsoft.UI.Xaml namespaces.
- 335 XAML references to app or third-party namespaces are not forecast.

## Review completeness
**FOCUSED REVIEW REQUIRED before requesting approval.**
The brief's item/size limits excluded entries; they were not removed from the assessment.
Extract only the named fields in bounded batches. Review omitted blockers, decisions, requirements and uncertainty; do not silently waive them.
- JSON `planPreview.projects`: 1 of 16 brief entries not shown.
- JSON `planPreview.projects[].steps`: 26 of 26 brief entries not shown.
- JSON `packageConfiguration`: 6 of 6 brief entries not shown.
- JSON `instructions`: 1 of 1 brief entries not shown.
- JSON `changes`: 15 of 15 brief entries not shown.
- JSON `contract.budgets`: 33 of 33 brief entries not shown.
- JSON `contract.checks`: 14 of 14 brief entries not shown.
- JSON `request.prepareRepairOnMissingCapability`: 3 of 3 brief entries not shown.
- JSON `gaps`: 9 of 9 brief entries not shown.
- JSON `projects`: 12 of 12 brief entries not shown.
- JSON `findings`: 13 of 13 brief entries not shown.
- JSON `coverage, request.smokeTestScript`: 6 of 6 brief entries not shown.
- JSON `inheritedInputs, workspaceInheritedInputs`: 1 of 1 brief entries not shown.
