using LudicWorlds;
using UnityEngine;

public class RotatingState : GameObjectState<CubeStateID>
{
    private GameObject cube;
    private float xRotSpeed = 20f;
    private float yRotSpeed = 10f;
    private float zRotSpeed = 5f;


    public RotatingState(IStateMachine<CubeStateID> stateMachine)
        : base(stateMachine, CubeStateID.Rotating)
    {
        this.cube = (stateMachine as MonoBehaviour).gameObject;
    }

    public override void Enter()
    {
        Debug.Log("RotatingState::Enter()");
    }

    public override void Update()
    {
        cube.transform.Rotate(xRotSpeed * Time.deltaTime, yRotSpeed * Time.deltaTime, zRotSpeed * Time.deltaTime);
    }

    public override void Exit()
    {
        Debug.Log("RotatingState::Exit");
    }
}
