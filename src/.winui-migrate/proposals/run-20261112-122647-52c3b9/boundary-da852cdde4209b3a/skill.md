---
name: winui2-to-winui3-resources-and-theming
version: 0.2.4
owner: sachikumar@microsoft.com
description: Use when localised strings come back empty, when theme brush keys fail to resolve, when a library's default styles stop being applied, or when migrating resource loading. The resource stack changes implementation, the build-time resource index is produced differently, unpackaged apps need it delivered alongside them, and many theme resource keys were renamed. Missing strings usually appear as blank UI rather than as an error.
user-invocable: false
kind: repair
pack: uwp
verify: build, launch
applies-to-message:
  - ControlsResourcesVersion
  - BackgroundSource
  - RevealBorderBrush
  - RevealBackgroundBrush
  - resources.pri
---

# Resources, localisation and theming

Three things move together here, and they are easy to confuse because they all fail as UI that looks
wrong rather than as an error.

The resource loader is a different implementation with a different type. The index it reads is
produced differently at build time, the neutral language has to be stated explicitly, and an
unpackaged app needs the index delivered next to it rather than inside a package.

Separately, the theme resource keys were renamed as part of a new set of design tokens, and the file
a library ships its default styles in resolves differently than it used to.

The failure mode throughout is silence. A string that cannot be found comes back empty, and empty
text in a label looks like a layout problem.

## Steps

1. Look up the resource loader type, the resource context type, and the theme resource keys in use
   with `winui-migrate lookup`. The key renames are per key, so look them up rather than guessing
   from the old name — the new names do not follow the old pattern.

2. Replace the loader. The way an instance is obtained changed as well as the type, because the old
   route was tied to the view concept that no longer exists.

3. Fix the build side. The project needs its resource items updated so the index is produced, and
   the neutral language has to be declared explicitly. Leaving it implicit builds successfully and
   produces an index that resolves nothing at runtime.

4. If the app is unpackaged, make sure the index ships beside the executable. This is a packaging
   step, not a code one, and it is the most common reason a migrated app has no text at all. See
   `winui2-to-winui3-packaging-and-identity`.

5. Update the theme resource keys. Search the XAML for the old key names and replace them one by
   one. A missing key is not a build error in XAML — it resolves to nothing, and the element renders
   with no brush.

6. Update the merged dictionaries. The file the framework's own defaults come from changed, so an
   app that merged the old one explicitly needs updating.

7. Re-check library default styles. A library that shipped its own default styles needs those
   reauthored, because the resolution path for them changed. Merging them explicitly from the
   application resources is the reliable route.

8. Check per-window theming. The requested theme now sits on the window rather than only on the
   application, which matters if the app has more than one window or lets the user change theme at
   runtime.

9. Remove XAML members and brushes that WinUI 3 no longer has. Each shows up as a XAML compiler
   error (WMC0011 unknown member, WMC0001 unknown type) naming the member:
   - `ControlsResourcesVersion` on `XamlControlsResources`: delete the attribute. WinUI 3 has one
     style set, so there is no version to choose.
   - `BackgroundSource` on `AcrylicBrush`: delete the attribute. WinUI 3 acrylic brushes are always
     in-app acrylic. If it was `HostBackdrop`, the see-through-the-window effect is lost. Say so in
     the change summary. Do not switch the window's backdrop to get it back without asking.
   - `RevealBorderBrush` and `RevealBackgroundBrush`: replace each one with a `SolidColorBrush`
     whose `Color` is the reveal brush's `FallbackColor`. A `RevealBorderBrush` without one becomes
     `Transparent`: that is its default fallback and how the border looks away from the pointer
     (its `Color` is the lit tint, not a resting colour). A `RevealBackgroundBrush` without one needs
     a theme brush chosen for it. Keep the resource key. The hover light is lost.

## Checking it worked

Run the app in a non-default language, not just the default one. The default often works by accident
when the index is broken, because the fallback is the language the strings were written in.

Look for empty labels rather than for errors. Walk the screens and confirm nothing is blank.

For theming, check both light and dark. A key that failed to resolve frequently looks acceptable in
one theme and unreadable in the other, because the element falls back to a default that happens to
suit one of them.

If the app is unpackaged, do this check from an installed copy rather than from the build output.
The build output often has the index sitting next to it for reasons the installer does not
reproduce.

## What this does not cover

Translating anything, or changing which languages are supported.

Choosing a window-level backdrop such as Mica or desktop acrylic to replace a lost host-backdrop
effect. That is a design decision for the app owner, and whether in-app acrylic is available
depends on the SDK version being targeted. Look it up rather than assuming.
