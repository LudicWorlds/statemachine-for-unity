using LudicWorlds;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingSizeState : GameObjectState<CubeStateID>
{
    private GameObject cube;
    private Vector3 originalScale;
    private float scale;
    private float time;

    public ChangingSizeState(IStateMachine<CubeStateID> stateMachine)
        : base(stateMachine, CubeStateID.ChangingSize)
    {
        cube = (stateMachine as MonoBehaviour).gameObject;
        originalScale = cube.transform.localScale;
        time = 0f;
    }

    public override void Enter()
    {
        Debug.Log("ChangingSizeState::Enter()");
    }

    public override void Update()
    {
       time += Time.deltaTime;
       scale = (Mathf.Sin(time) + 1.5f); // Sine wave oscillates between 0.5 and 1.5 
       cube.transform.localScale = originalScale * scale;
    }

    public override void Exit()
    {
        Debug.Log("ChangingSizeState::Exit()");     
    }
}
