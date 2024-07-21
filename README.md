# State Machine for Unity

A simple and flexible state machine implementation in C# designed for Unity projects. This library allows you to create and manage states in a clear and organized manner.

This state machine implementation includes:

- Interfaces and abstract classes to define states and state machines.
- A finite-state machine ([FSM](https://wikipedia.org/wiki/Finite-state_machine)) implementation.
- A Unity-specific state machine for MonoBehaviour-based states.


## Features
- Easy to implement and extend
- Supports different types of states
- Manages state transitions and lifecycle
- Compatible with Unity's MonoBehaviour


## Installation

To use this state machine in your Unity project:

1. Download the latest release from the [Releases page](https://github.com/LudicWorlds/statemachine-for-unity/releases).
2. Import the `StateMachineForUnity.unitypackage`:
   - Go to **Assets > Import Package > Custom Package...**.
   - Select the `StateMachineForUnity.unitypackage` file.
   - In the Import Unity Package window, ensure all items are checked and click **Import**.

## Usage

To gain an understanding of how to use the state machine, it's a good idea to take a look at the 'StateMachineDemoScene'.

To open and try out this demo scene:
1. Download or clone this repository to your PC.
2. Open the project in Unity.
3. Open the demo scene located at `Assets/Scenes/StateMachineDemoScene.unity`.
4. In the scene, you will find a 'Cube' GameObject with the `CubeStateMachine` script attached.
5. Press the 'Play' button in the Editor to start 'Play Mode'.
6. Switch between different states (Rotating, ChangingSize, ChangingColor) by pressing the number keys (1, 2, 3).

You will find the example scripts in the 'Assets/Scripts' folder. These should give you a good idea of how to use the state machine.


## License

This project is released under the CC0 License. Please read the [LICENSE](LICENSE) file for more details.


## Disclaimer
This project is provided "as is" without warranty of any kind. Use at your own risk. The authors are not responsible for any damage or data loss resulting from the use of this package. Compatibility and performance may vary depending on your system configuration.
