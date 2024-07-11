using UnityEngine;

namespace LudicWorlds
{
    public class IdleState : GameObjectState<string>
    {
        public IdleState( IStateMachine<string> stateMachine, string id ) : base(stateMachine, id)
        {
        }

        public override void Enter()
        {
            Debug.Log("-> IdleState::Enter()");
        }

        public override void Update() { }
        public override void Exit() { }
    }
}