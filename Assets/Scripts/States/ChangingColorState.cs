using LudicWorlds;
using UnityEngine;

public class ChangingColorState : GameObjectState<CubeStateID>
{
    private GameObject cube;
    private Renderer cubeRenderer;
    private float hue;
    private float changeSpeed = 0.2f;

    public ChangingColorState(IStateMachine<CubeStateID> stateMachine)
        : base(stateMachine, CubeStateID.ChangingColor)
    {
        this.cube = (stateMachine as MonoBehaviour).gameObject;
        this.cubeRenderer = cube.GetComponent<Renderer>();
    }

    public override void Enter()
    {
        Debug.Log("ChangingColorState::Enter()");
    }

    public override void Update()
    {
        hue += changeSpeed * Time.deltaTime;
        if (hue > 1f)
        {
            hue = 0f;
        }
        cubeRenderer.material.color = Color.HSVToRGB(hue, 1f, 1f);
    }

    public override void Exit()
    {
        Debug.Log("ChangingColorState::Exit()");
    }
}
