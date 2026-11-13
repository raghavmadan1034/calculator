# Migration assessment review brief


## Assessment
Assessment `c9b8be164e984ceeb602f36e1648e91c`, revision 2
Approval hash: `9b5866c1cc87a31fde0697467355fe88e8c81b5a9d35319fa15f1d5361a003c5`
This bounded review is approval-ready. Full exact evidence remains in sibling assessment.json and assessment.md.
For omitted informational detail, inspect one named field only on demand. Page through the complete stage inventory before approval.
Approval authorizes the reviewed direction, not proof of compatibility. Requirements bind; preferences steer.
No application copy, restore, build, launch or tests were executed by this assessment.
12 projects; 6834 API/control findings; 453 identifiable test declarations (inventory, not coverage).

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

## Decisions to answer: 17 (5 not doable, 10 decision required, 2 unknown; 0 unanswered)
- D1 not-doable, source CalcManager (1 use): The project cannot be migrated: C++ project, not something this tool can migrate Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D2 not-doable, source CalculatorUnitTests (1 use): The project cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D3 not-doable, source GraphControl (1 use): The project cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D4 not-doable, source GraphingImpl (1 use): The project cannot be migrated: C++ project, not something this tool can migrate Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D5 not-doable, source TraceLogging (1 use): The project cannot be migrated: C++/CX project, which WinUI 3 does not support; code that uses it needs a port to C++/WinRT or has to be left out Options: exclude-scope (the only way to clear it). Answered: exclude-scope.
- D6 decision-required, xaml-control RevealBackgroundBrush (8 uses): It exists only in UWP XAML or WinUI 2: only Windows SDK Windows.UI.Xaml.Media.RevealBackgroundBrush; absent from WinUI 3. Options: (a) Replace each Reveal background brush resource with a SolidColorBrush of its authored FallbackColor [replace] [recommended]; (b) Choose a theme brush for each control that used it (winui2-to-winui3-resources-and-theming) [replace]; defer, exclude-scope. Answered: (a) Replace each Reveal background brush resource with a SolidColorBrush of its authored FallbackColor.
- D7 decision-required, xaml-control RevealBorderBrush (4 uses): It exists only in UWP XAML or WinUI 2: only Windows SDK Windows.UI.Xaml.Media.RevealBorderBrush; absent from WinUI 3. Options: (a) Replace each Reveal border brush resource with a SolidColorBrush of its authored FallbackColor [replace] [recommended]; (b) Choose a theme border brush for each control that used it (winui2-to-winui3-resources-and-theming) [replace]; defer, exclude-scope. Answered: (a) Replace each Reveal border brush resource with a SolidColorBrush of its authored FallbackColor.
- D8 decision-required, xaml-member BackdropMaterial.ApplyToRootOrPageBackground (1 use): It is declared by no metadata that was read: Microsoft.UI.Xaml.Controls.BackdropMaterial is absent from WinUI 3 and the Windows SDK. Options: (a) Remove the attached property; the page keeps its authored background [remove] [recommended]; (b) Remove the attached property and set Window.SystemBackdrop to a MicaBackdrop on the window that hosts the page [replace]; defer, exclude-scope. Answered: (a) Remove the attached property; the page keeps its authored background.
- D9 decision-required, api ApplicationData (19 uses): WinUI 3 has no drop-in replacement. Returns null/throws when unpackaged. Use Environment.SpecialFolder.LocalApplicationData (Win32). Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity.
- D10 decision-required, api Suspending (2 uses): WinUI 3 has no drop-in replacement. Deferral-only subscriptions have a checked removal. Meaningful application work must remain until a source-grounded desktop trigger is established. The window-close recipe preserves and awaits existing work only under an applicable approved lifecycle requirement. Options: (a) Keep the suspension work and run it on the primary window's first close request: cancel that close, await the work, then close the window once (winui2-to-winui3-lifecycle) [replace] [requires desktop-lifecycle=window-close] [recommended]; (b) Move the suspension work to another desktop trigger the owner chooses, such as an explicit save or a change of window visibility (winui2-to-winui3-lifecycle) [replace]; defer, exclude-scope. Answered: (a) Keep the suspension work and run it on the primary window's first close request: cancel that close, await the work, then close the window once (winui2-to-winui3-lifecycle).
- D11 decision-required, api SystemNavigationManager (2 uses): WinUI 3 has no drop-in replacement. The shell back button is gone with no replacement. Back has to be built per window, normally the NavigationView back button or a title bar control. Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-windowing [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-windowing.
- D12 decision-required, api Windows.Storage.ApplicationData (2 uses): WinUI 3 has no drop-in replacement. Returns null/throws when unpackaged. Use Environment.SpecialFolder.LocalApplicationData (Win32). Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-packaging-and-identity.
- D13 decision-required, api Windows.UI.Xaml.Controls.Pivot (1 use): WinUI 3 has no drop-in replacement. Not ported, by design, and it is not coming back. SelectorBar is the segmented replacement; TabView is the one for tabbed documents. Neither is a drop-in. Options: (a) Rework it as the dictionary note directs, using winui2-to-winui3-control-parity-triage [recommended]; defer, exclude-scope. Answered: (a) Rework it as the dictionary note directs, using winui2-to-winui3-control-parity-triage.
- D14 decision-required, runtime-path ResourceContext.GetForCurrentView (1 use): It compiles and then behaves differently: current-view resource qualifiers differ in MRT Core. Options: (a) Choose an MRT Core context and preserve every qualifier the app reads or writes [recommended]; defer, exclude-scope. Answered: (a) Choose an MRT Core context and preserve every qualifier the app reads or writes.
- D15 decision-required, runtime-path SystemNavigationManager.GetForCurrentView (2 uses): It compiles and then behaves differently: the UWP system back button has no desktop current view. Options: (a) Use existing in-app navigation or an owning-window back affordance [recommended]; defer, exclude-scope. Answered: (a) Use existing in-app navigation or an owning-window back affordance.
- D16 unknown, package MSTest (1 use): No rule in dependency-rules.tsv classifies it. Options: defer, exclude-scope. Answered: defer.
- D17 unknown, native ITextDocument4 (1 use): No rule in native-interop-rules.tsv classifies the Com boundary. Options: defer, exclude-scope. Answered: defer.
- The loop acts on the answers when a build error names the subject: the recommended option keeps the rule's repair, another option rules it out for a person or the model, defer stops to ask, and exclude-scope leaves it unchanged.

## Next step
- Approve this revision and start the migration: `winui-migrate migrate --assessment "C:\Users\raghavmadan\.copilot\session-state\52f15054-86e8-4212-b97b-e50be2b17a1f\files\calculator-review\assessments\c9b8be164e984ceeb602f36e1648e91c\revisions\0002-9b5866c1cc87\assessment.json" --approve 9b5866c1cc87a31fde0697467355fe88e8c81b5a9d35319fa15f1d5361a003c5`
- Or change direction with `--feedback <json>`. At the interactive prompt: approve, reject, answer D1=a, or feedback <json>.

## Readiness scores (source queries, not verified)
- Verdict: Feasibility 58.3 / 100, NO, 5 blockers, 2 high-risk areas (control_compatibility, runtime_path_coverage), not fully assessed: dependency_closure, native_interop_coverage.
- EVAL-01 source_completeness: coverage 100.0%, feasibility 58.3%, risk blocker.
- EVAL-02 control_compatibility: coverage 100.0%, feasibility 98.9%, risk high.
- EVAL-03 managed_api_compatibility: coverage 100.0%, feasibility 100.0%, risk low.
- EVAL-04 dependency_closure: coverage 92.9%, feasibility 92.9%, risk medium.
- EVAL-05 native_interop_coverage: coverage 80.0%, feasibility 80.0%, risk low.
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
- EVAL-02 high: XAML control RevealBackgroundBrush (8 uses) exists only in UWP XAML or WinUI 2; it needs a redesign decision.
- EVAL-02 high: XAML control RevealBorderBrush (4 uses) exists only in UWP XAML or WinUI 2; it needs a redesign decision.
- EVAL-02 high: XAML member BackdropMaterial.ApplyToRootOrPageBackground (1 use) is declared by no metadata that was read; it needs a redesign decision.
- EVAL-06 high: Runtime path ResourceContext.GetForCurrentView needs a decision: current-view resource qualifiers differ in MRT Core. Alternative: choose an MRT Core context and preserve every qualifier the app reads or writes

## Proposed package source configuration (not applied)

## Review completeness
**FOCUSED REVIEW REQUIRED before requesting approval.**
The brief's item/size limits excluded entries; they were not removed from the assessment.
Extract only the named fields in bounded batches. Review omitted blockers, decisions, requirements and uncertainty; do not silently waive them.
- JSON `scorecard.dimensions[].riskReasons`: 1 of 10 brief entries not shown.
- JSON `planPreview.projects`: 16 of 16 brief entries not shown.
- JSON `planPreview.projects[].steps`: 30 of 30 brief entries not shown.
- JSON `packageConfiguration`: 6 of 6 brief entries not shown.
- JSON `instructions`: 1 of 1 brief entries not shown.
- JSON `changes`: 18 of 18 brief entries not shown.
- JSON `contract.budgets`: 33 of 33 brief entries not shown.
- JSON `contract.checks`: 14 of 14 brief entries not shown.
- JSON `request.prepareRepairOnMissingCapability`: 3 of 3 brief entries not shown.
- JSON `gaps`: 12 of 12 brief entries not shown.
- JSON `projects`: 12 of 12 brief entries not shown.
- JSON `findings`: 13 of 13 brief entries not shown.
- JSON `coverage, request.smokeTestScript`: 6 of 6 brief entries not shown.
- JSON `inheritedInputs, workspaceInheritedInputs`: 1 of 1 brief entries not shown.
