# eSTOL Toolbar Panel

An in-sim MSFS toolbar panel that shows live data from the eSTOL Training Tool desktop app:
takeoff distance, landing distance, wind, and the same aligned/on-lineup/NOT ALIGNED indicator
shown in the desktop app's top bar (red/orange/green/yellow).

It does **not** talk to SimConnect itself. It polls a small local status server that the
desktop app (`STOL_Training_Tool_Core`) now runs in the background (`PanelServer.cs`,
`GET http://127.0.0.1:7865/status`). Keep the desktop app running for the panel to show data.

## Prerequisites

- MSFS SDK installed, with the `MSFS_SDK` environment variable pointing at its root
  (the SDK installer usually sets this for you; verify with `echo %MSFS_SDK%`).

## Build

Run `build.bat` from this folder. It invokes `fspackagetool.exe` against
`Build\estol-toolbar-panel.xml`, then copies the compiled `.spb` into `InGamePanels\`.

```
build.bat
```

## Install

Copy this entire `eSTOL_Toolbar_Panel` folder into your Community folder (rename it if you like,
e.g. `estol-toolbar-panel`), but **do not** copy the `Build\` subfolder — it's only needed to
compile the `.spb` and isn't part of the runtime package.

After installing, launch MSFS, and a new eSTOL icon appears in the in-sim toolbar. Click it to
open the panel.

## Configuration

The panel polls `http://127.0.0.1:7865/status` by default (see `PanelHost`/`PanelPort` in the
desktop app's `config.json`). If you change the port there, update `STATUS_URL` in
`html_ui/InGamePanels/eSTOLTrainingPanel/panel.js` to match. This file is loose (not compiled
into the `.spb`), so no rebuild is needed for JS/HTML/CSS changes — only rebuild when
`Build/PackageSources` changes (panel id, icon, sizing).

## Structure

`content-fit="true"` on the outer `<ingame-ui>` measures whatever is placed directly inside it,
so the outer shell (`eSTOLTrainingPanel.html`/`.js`/`.css`) is kept to the bare minimum proven
pattern (mirrored from a real working addon, VPforce TelemFFB's own in-sim panel): an empty
`<iframe>`. All the actual UI (aligned bar, takeoff/landing tiles, wind compass, status polling)
lives in `panel.html`/`panel.js`/`panel.css`, loaded into that iframe once the panel is opened.

The panel id (`PANEL_ESTOL_TRAINING_V2`), custom element tag (`ingamepanel-estol-training`),
icon id, folder name, and outer file names were all changed from an earlier iteration
(`PANEL_ESTOL_PANEL` / `eSTOLPanel`) specifically to shed any window size/position MSFS may have
already persisted (per panel id, via its DataStorage API) from testing that earlier version —
if the old id kept reopening huge no matter what the package shipped, this is why. Bump the `_V2`
(or the whole id) again if you ever need a clean slate for the same reason.

Default size (`defaultWidth`/`defaultHeight` in `Build/PackageSources/estol-toolbar-panel.xml`)
is intentionally tiny (`45x60`, matching TelemFFB's own proven values) rather than a "nice" preset
size — `resizeDirections="Both"` lets you drag it open by hand on first use. Larger explicit
defaults were tried and misbehaved under `content-fit`; this is the values known to work.

## Notes

- `layout.json`'s size for `InGamePanels/estol-toolbar-panel.spb` is a placeholder until you
  build — it isn't strictly validated by MSFS for Community packages, but you can update it to
  the real compiled file size if you want it accurate.
- The takeoff/landing tiles keep showing the last completed run's numbers until a new one is
  recorded, matching the desktop app's results box.
