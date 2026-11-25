Omission
CS 583 — 3D Game Programming | Group Project
Engine: Unity 6000.5.9f1
Genre: Third-person survival horror
Status: Halfway-review prototype
Team

Member
General responsibilities
Keith Macario
Enemy AI, Movement Systems
Lip Nguyen
Level Design, Environment, Lighting
Austin Friesen
Menus, UI/UX, Scene Transitions
Tanuj Thummala
Project Lead, General Programming, Audio
Tri Pham
Quality Assurance

About the game
Omission is a third-person survival horror game set around a remote research facility. The player takes the role of a scientist trying to shut down a portal in the facility's basement. The intended experience emphasizes tense exploration, limited resources, alien-like threats, and occasional puzzle-solving, with inspiration from classic third-person survival horror games.

The longer-term design considers exploring interconnected rooms, avoiding or fighting enemies, interacting with objects, and managing limited supplies. These are our design goals, and are subject to change depending on time constraints.
Current prototype (halfway review)
The current playable prototype demonstrates:

A research-facility corridor/test level assembled using imported environment assets.
A third-person character with keyboard movement, sprinting, jumping, and mouse-controlled camera movement.
A flashlight that can be toggled on and off.
Atmospheric environmental lighting, including flickering lights.
A main menu with a Start button that transitions into the gameplay scene.
An Exit button intended to close the standalone application.

The current prototype is focused on establishing the environment, controller, and menu-to-gameplay flow. Enemy encounters, combat, inventory, stamina limits, crouching, and other planned mechanics are not yet part of the verified halfway-review functionality.
Controls
Input
Action
W / A / S / D
Move
Mouse
Rotate third-person camera
Left Shift + movement
Sprint
Space
Jump
F
Toggle flashlight


Controls describe the current tested prototype and may change during development.
Requirements
Unity Editor: 6000.5.9f1
Git and Git LFS to retrieve the repository and its binary assets.
A machine capable of running the Unity project.

The project uses Unity Starter Assets for its third-person controller and third-party environment assets. Required Unity packages should be resolved from the project's Packages/manifest.json when Unity opens the project.
Getting started
Install Unity Hub and Unity Editor 6000.5.9f1.

Install Git and Git LFS.

Clone the repository, then enter its directory:

git clone <REPOSITORY_URL>
cd <REPOSITORY_DIRECTORY>

Enable Git LFS and download the binary assets:

git lfs install
git lfs pull

Open the repository folder as a project in Unity Hub, using editor version 6000.5.9f1. Allow the first import to finish; it may take a while.

Open Assets/Scenes/MainMenu.unity and press Play. Select Start to load the gameplay scene (Test-Level).

For the latest integrated team work, use the development branch. Before changing branches, close Unity and check git status so that local changes are not lost. If working from an existing clone, fetch and update your branch before opening the project.

Important: If Unity reports that .fbx, .png, .tif, .exr, or .wav files cannot be read, first check that Git LFS is installed and run git lfs pull. Missing LFS objects previously caused widespread import failures on a fresh checkout.
Scenes
Scene
Purpose
Assets/Scenes/MainMenu.unity
Main menu and Start/Exit controls
Assets/Scenes/Test-Level.unity
Current playable corridor/test level


SampleScene may also appear in the project's scene list; it is not part of the demonstrated menu-to-gameplay flow.

Known issues and limitations
Mouse cursor after scene transition: The cursor may remain visible/unlocked after selecting Start. The scene loads and the controller otherwise works; cursor handling remains to be fixed.
Starter Assets deprecation warnings: Some imported editor scripts use Unity APIs marked obsolete in 6000.5.9f1. These warnings have not prevented gameplay.
Starter Assets Readme log: The editor may print Couldn't find a readme from an imported tutorial script. This is unrelated to this repository's README.md.
Git LFS uppercase extension: The repository's .gitattributes tracks *.png but not *.PNG; an uppercase ReadMeImg.PNG file may repeatedly appear modified. Track and resolve this separately; do not accidentally include it in unrelated commits.
Prototype scope: The current scene is a short demonstration environment, not a complete survival horror level.
Planned development
Future work may include stamina-limited sprinting, crouching, more refined camera/flashlight behavior, enemy movement and encounters, interactions, health/combat systems, and additional environments. Scope will be adjusted to prioritize a playable final demonstration.
Development workflow
main: stable project state.
development: shared integration and testing branch.
Feature branches: individual work merged into development after review and testing.
Prefer focused commits with descriptive messages. Keep custom game scripts, scenes, and prefabs separate from imported asset packages where practical.
Include Unity .meta files in commits. Do not commit generated Library/, Temp/, or IDE cache files.
Coordinate edits to shared Unity scenes and prefabs to reduce merge conflicts.
Third-party assets
Unity — First Person / Third Person Character Controllers (Starter Assets): third-person movement, camera, and character animations. https://assetstore.unity.com/packages/3d/characters/first-person-third-person-character-controllers-196526
SciFiLike environment asset pack: corridor/environment models and materials. TODO: Add link
Other imported resources: TODO: Add link

