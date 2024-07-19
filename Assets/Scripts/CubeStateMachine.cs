using LudicWorlds;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CubeStateID
{
    Rotating,
    ChangingSize,
    ChangingColor
}

public class CubeStateMachine : GameObjectStateMachine<CubeStateID>
{
    protected override void InitStates()
    {
        AddState(new RotatingState(this));
        AddState(new ChangingSizeState(this));
        AddState(new ChangingColorState(this));

        SetState(CubeStateID.Rotating);
    }


    protected override void Start()
    {
        base.Start(); // <- InitStates() is called from here
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update(); // <- StateMachine is updated here
        
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetState(CubeStateID.Rotating);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetState(CubeStateID.ChangingSize);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetState(CubeStateID.ChangingColor);
        }
    }
}
