# Cozy Cafe VR

An in-progress Unity prototype for exploring a cozy cafeteria/cafe in first
person, with an experimental gaze interaction for picking up a coffee cup.

## Current status

This repository contains the Unity project source and settings. It is a
prototype rather than a finished or released game.

| Area | Status |
| --- | --- |
| Cafe environment | Present in `Assets/Scenes/MainScene.unity` |
| Unity Editor play mode | Intended to work with the main scene |
| PC controls | Mouse look plus legacy `Horizontal`/`Vertical` input (typically WASD) |
| Gaze interaction | Gaze at the coffee cup for 1.5 seconds to toggle it up/down |
| Android VR | Google Cardboard XR settings and loader are configured |
| Meta Quest | Not configured; no Quest/OpenXR/Oculus package or loader is included |
| Mobile/PC release | No APK, AAB, EXE, or other distributable build is included |

The project has not been verified here by running Unity or installing a build
on a phone, Cardboard headset, PC, or Meta Quest. Treat the Android/Cardboard
configuration as setup to continue, not as evidence of a published release.

## Requirements

- Unity `6000.3.7f1` (see `ProjectSettings/ProjectVersion.txt`)
- Android Build Support if building for a phone/Cardboard viewer
- A phone-compatible Google Cardboard viewer for the configured mobile XR path

## Open and try the prototype

1. Clone the repository.
2. Open the repository folder in Unity Hub using the required Unity version.
3. Open `Assets/Scenes/MainScene.unity`.
4. Press **Play** in the Unity Editor.
5. In the Editor, use the mouse to look around and the usual legacy
   `Horizontal`/`Vertical` controls (WASD on the default keyboard mapping) to
   move. Look at the coffee cup and keep the gaze on it for 1.5 seconds.

`Assets/Scenes/SampleScene.unity` is retained as a sample scene, but it is
disabled in the build scene list. `MainScene` is the enabled scene.

## Android/Cardboard direction

The project includes the Google Cardboard XR plugin and Android XR loader
settings. To continue toward a phone build, install Android Build Support in
Unity Hub, select Android as the build target, confirm `MainScene` is enabled
in Build Profiles/Build Settings, and create an APK for a test device.
Installation and device testing are still required; this repository does not
include a ready-to-install APK.

## Project layout

- `Assets/Scenes/` — cafe and sample Unity scenes
- `Assets/GazeInteractor.cs` — timed forward-ray gaze interaction
- `Assets/GazeCup.cs` — coffee-cup interaction response
- `Assets/MouseMovementTemp.cs` — Editor/desktop mouse-look and movement
- `Assets/XR/` — Cardboard XR settings and loader configuration
- `Packages/` — Unity package manifest and lock file
- `ProjectSettings/` — Unity version, input, rendering, and build settings

Generated Unity caches, logs, local user settings, and IDE project files are
intentionally excluded from version control.

## Next steps

- Run and tune the scene in Unity Editor.
- Test an Android/Cardboard build on a real device.
- Add a real interaction/task loop, UI, audio, and completion state.
- If Quest support is a goal, add and configure a Quest-compatible XR provider
  (for example OpenXR) and test with the target headset.
