---
name: winui2-to-winui3-hwnd-interop
version: 0.2.4
owner: sachikumar@microsoft.com
description: Use when a file picker, folder picker, message dialog, share or print call compiles but throws or never shows anything at runtime. In UWP these APIs found the current view by themselves. In a desktop process there is no current view, so each one has to be told which window it belongs to before it is used. The API surface is unchanged, so nothing about this fails at build time.
user-invocable: false
kind: audit
pack: uwp
verify: build, launch
applies-to-source:
  - FileOpenPicker
  - FileSavePicker
  - FolderPicker
  - MessageDialog
  - DataTransferManager
  - PrintManager
---

# Attaching a window to APIs that used to find one themselves

A set of system APIs used to locate the calling view on their own. A desktop process has no such
view, so those APIs have to be handed a window handle before they are used.

The important property of this change is that **the API surface did not change**. The calls still
compile exactly as written. They fail when they run — usually by throwing, sometimes by returning
without showing anything at all.

This affects around a dozen call sites in a typical app, and they are always the same kinds: picking
a file or folder, showing a system message dialog, sharing, and printing.

## Steps

1. Look up how to obtain a window handle from a window, and the initialisation call for the API in
   question, with `winui-migrate lookup`. There is more than one shape — some surfaces take a handle
   through an initialisation call, and some are obtained through an interop interface instead of
   their old static accessor. Do not assume one pattern covers all of them.

2. Find the call sites. Search for file and folder pickers, the system message dialog, the data
   transfer manager, and print. These are not reported by the build, so this search is the only way
   they are found.

3. For each one, get a window. This is the real work. The call site usually sits in a view model, a
   service or a helper that has no window and no reason to know about one. Options, in order of
   preference:

   - pass the window in from the caller that has one
   - hold it on a small object that already represents the current window
   - as a last resort, store it once at startup, accepting that this breaks if a second window is
     added

   If the codebase already did `Window.Current` here, this is the same problem again, and
   `winui2-to-winui3-windowing` covers it.

4. Attach the handle before the call that shows the surface, not after. Attaching after the show
   call compiles and does nothing.

5. Check the ordering when the surface is reused. A picker held in a field and shown twice needs the
   handle before each use if the window can change.

6. Prefer the in-app dialog over the system message dialog where the code is showing a simple
   prompt. It avoids the interop entirely and matches the rest of the UI. See
   `winui2-to-winui3-dialogs-and-popups`.

## Checking it worked

Nothing here can be checked by building. Every call site from step 2 has to be run by hand.

For each: the surface appears, it appears over the right window, and cancelling it returns control
properly. If the app has more than one window, open the second one and use the surface from there
too. A handle stored once at startup passes the first test and fails the second.

## What this does not cover

Whether these APIs work at all in the chosen packaging mode. Some of them behave differently
unpackaged. See `winui2-to-winui3-packaging-and-identity`.

Setting the XAML root on in-app dialogs and popups. That is a different requirement with a similar
shape, and it is covered by `winui2-to-winui3-dialogs-and-popups`.
