---
name: winui2-to-winui3-lifecycle
version: 0.2.4
owner: sachikumar@microsoft.com
description: Use when a build error names a suspending, resuming, entered-background or leaving-background event, or when migrating an app that saves its state when the system suspends it, or that uses out-of-process background tasks. These are not renamed in WinUI 3. Suspension does not exist in a desktop process and the background task model is gone, so both need redesigning rather than substituting.
user-invocable: false
kind: repair
pack: uwp
verify: build, launch
applies-to-subject:
  - SuspendingEventArgs
  - SuspendingDeferral
  - EnteredBackgroundEventArgs
  - LeavingBackgroundEventArgs
applies-to-message:
  - "'Suspending'"
  - "'Resuming'"
  - "'EnteredBackground'"
  - "'LeavingBackground'"
---

# Lifecycle

A UWP app lived under a lifecycle the operating system controlled. It was told when it was about to
be suspended, and it saved its state at that point. A WinUI 3 app is an ordinary desktop process. It
runs until it exits.

The events therefore do not have replacements. They are removed, and code that relies on them has to
be rewritten around a different assumption: **nothing will tell the app to save.** It has to decide
for itself when to.

The same applies to background work. The UWP trigger model ran code out of process when the app was
not running. There is no desktop equivalent, so this is an architecture decision per task rather
than a port.

## Steps

1. Look up the removed lifecycle events with `winui-migrate lookup` to confirm which of them have no
   replacement in the version being targeted, rather than assuming from this file.

2. Find every handler for the suspension and background-state events, and read what each one
   actually does. In practice they fall into three groups:

   - saving state or user data
   - releasing something expensive, such as a device, a connection or a large cache
   - telemetry about how long the app was in the foreground

3. Rewrite the saving group first, because it is the one where the migration can lose user data.
   Saving has to move to a point the app controls. The usual options are on a timer while idle, on
   every meaningful change, and when the window closes. Choose deliberately. Saving only on window
   close loses everything if the process is killed.

4. Establish the releasing group's desktop trigger from the actual ownership and requirements.
   Do not discard application cleanup merely because process exit eventually releases OS resources.
   Keep explicit flush, device-stop and application bookkeeping work unless its removal is justified.

5. Preserve the intent of telemetry where required, using a deliberately selected desktop event.
   Do not automatically delete it or equate process lifetime with foreground time.

6. Handle termination separately. The unhandled exception event on the application still exists, but
   a desktop process can also fail in ways that never reach it. If the app reports crashes, it needs
   a process-level handler as well as the XAML one.

7. Take background tasks one at a time. Each needs a decision, and the decision depends on when the
   work has to run:

   - only while the app is open: move it in process, this is the easy case
   - on a schedule, app closed: a scheduled task
   - continuously, app closed: a service
   - in response to a system event: check whether the event is even observable from a desktop
     process before designing around it

   If a task cannot be placed in one of those, report it rather than approximating it. An
   approximated background task that runs at the wrong time is worse than one that is known to be
   missing.

## Tool-backed recipes

`MigrateUwpLifecycle` revision 3 removes subscriptions to proven-empty callbacks, including
the exact straight-line deferral-only `GetDeferral()` / `Complete()` boilerplate. Handler,
argument and deferral-variable names are discovered, not fixed. Application work remains intact
and produces a structured capability requirement instead of being deleted.

For existing work that must run before a window closes, `MigrateDesktopLifecycle` targets the
C# callback file and requires `handler`, `project`, `window` and `policy` parameters.
The supported policy is `window-close`. The window must be an actual retained source reference,
not an invented global or an invocation. Verify its type, initialization and owning UI thread.

This recipe requires an applicable, approved instruction with `kind: outcome`,
`strength: requirement`, `subject: desktop-lifecycle`, and `value: window-close`.
Answering the assessment's `Suspending` decision with its window-close option adds that
requirement for the whole migration; another answer removes it again.
Without that authority it writes nothing and returns `ProductDecision`. A proposed step's own
policy parameter is not approval. Do not manufacture the requirement from a callback's name:
source establishes what work exists, not necessarily when the product wants it performed.

The tool preserves a private instance callback's body, removes only recognized deferral
scaffolding, and converts subscriptions/unsubscriptions to an awaitable per-window coordinator.
It refuses extra callback references, unsupported event-argument use and customized helpers.
Partial-class source references are checked conservatively; linked layouts need a separate recipe.
Synchronous callbacks retain their work in a synchronous wrapper returning a completed task.
Constructor subscriptions are not blindly changed to dereference an as-yet-uncreated Window.
A single unconditional constructor subscription with one matching activation site in the same
class can be registered immediately after that activation instead. Ambiguous placement,
conditional constructor hooks and other unsupported initialization paths remain capability gaps.

The generated coordinator cancels the initial user-close request, awaits registered callbacks
in order, coalesces repeated requests, then sends another close request through the normal
closing handlers. Other handlers can still cancel. Failed work is logged and leaves the window
open. Registration must occur on the owning UI thread. Programmatic destruction or process
termination can bypass this policy; window close is not crash-safe persistence.

`MissingCapability` means the source/policy needs another execution recipe, not necessarily
another product decision. Let bounded planning try supported alternatives. Do not keep retrying
the same rejected step or hand-edit the application outside the recorded executor.

## Bounded repair proposer recipe

When a reviewed `MissingCapability` group is handed to the bounded read-only repair proposer,
the skill is the technical recipe and the controller profile is only the safety contract.
Investigate every removed UWP suspension subscription, unsubscription and callback in the writable
files, plus the already-established primary `Window` creation and active XAML navigation path.
Preserve every removed suspension callback's work and ordering, for example stopping in-progress
work and persisting state. Do not delete persistence, approximate background execution, invent a
timer, service, scheduled task, global accessor, second `Window`, or new product policy.

A requirement that the first primary-window close request await work authorizes one guarded
`AppWindow.Closing` sequence: cancel before the first await, reject reentrant preparation, await
all applicable close work, then call the retained `Microsoft.UI.Xaml.Window.Close` exactly once.
The subsequent `Closing` notification must be allowed to complete without repeating the work.
The app-owned primary `Window` remains the lifetime owner and the existing dependency-registration
path remains unchanged.

Convert removed suspension callbacks into ordinary `Task`-returning close-preparation methods that
do not accept `SuspendingEventArgs` or acquire deferrals. Preserve device stop, file handling,
navigation, persisted UI position/state, subscriptions unrelated to suspension, and exception
behavior. Remove obsolete `Application.Current.Suspending` hooks and `Windows.ApplicationModel`
imports only when no longer used. Establish one close coordinator; do not let multiple leaf controls
each issue competing `Window.Close` calls. Use the readable XAML/navigation structure to invoke only
close work belonging to the active content. If that active-content route cannot be established from
the staged files, return unresolved rather than inventing a registry or static callback.

## Checking it worked

The build errors naming the removed events are gone.

Then test data safety directly, because that is what this change risks. Make a change in the app,
do not use any explicit save, and close it the way a user would. Reopen and confirm the change
survived. Then do the same but end the process abruptly. What survives there is what the new save
policy actually gives you, and it should match what was decided in step 3.

For each background task, confirm the replacement runs when the app is closed, on a machine where
the old packaged build was never installed.

## What this does not cover

Choosing the save policy. How much unsaved work is acceptable to lose is a product question.

Building and installing services or scheduled tasks, including how they are delivered and updated.
That is installer work, and it is often the larger half of removing a background task.
