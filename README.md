# Cozy Cafe VR

An immersive Unity experience for exploring a cozy cafeteria/cafe in first
person, with gaze-based interaction for picking up a coffee cup.

## Features and platform setup

| Area | Status |
| --- | --- |
| Cafe environment | Present in `Assets/Scenes/MainScene.unity` |
| Unity Editor play mode | Main scene is ready to open and play |
| PC controls | Mouse look plus legacy `Horizontal`/`Vertical` input (typically WASD) |
| Gaze interaction | Gaze at the coffee cup for 1.5 seconds to toggle it up/down |
| Android VR | Google Cardboard XR settings and loader are configured |
| Rendering | Universal Render Pipeline assets for PC and mobile |

## Author

**Rudransh Verma**

Course project for **DES643 — Design for AR & VR**.

## Requirements

- Unity `6000.3.7f1` (see `ProjectSettings/ProjectVersion.txt`)
- Android Build Support if building for a phone/Cardboard viewer
- A phone-compatible Google Cardboard viewer for the configured mobile XR path

## Open and try the experience

1. Clone the repository.
2. Open the repository folder in Unity Hub using the required Unity version.
3. Open `Assets/Scenes/MainScene.unity`.
4. Press **Play** in the Unity Editor.
5. In the Editor, use the mouse to look around and the usual legacy
   `Horizontal`/`Vertical` controls (WASD on the default keyboard mapping) to
   move. Look at the coffee cup and keep the gaze on it for 1.5 seconds.

`Assets/Scenes/SampleScene.unity` is retained as a sample scene, but it is
disabled in the build scene list. `MainScene` is the enabled scene.

## Android/Cardboard build

The project includes the Google Cardboard XR plugin and Android XR loader
settings. Install Android Build Support in Unity Hub, select Android as the
build target, confirm `MainScene` is enabled in Build Profiles/Build Settings,
and create an APK for a compatible phone and Cardboard viewer.

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

## Development directions

- Extend the cafe with additional interactive objects and activities.
- Add UI, audio, and environmental feedback.
- Configure a Quest-compatible XR provider such as OpenXR when targeting
  Meta Quest hardware.
