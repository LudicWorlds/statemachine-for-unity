using System;

namespace LudicWorlds
{
	public abstract class State<T> : IState<T>
	{
        protected T id;
		protected IStateMachine<T> stateMachine;

		protected T nextStateId;
		protected T prevStateId;

        protected Boolean isDisposed = false;


		public T ID 
		{
			get { return id; }
		}
		
		public State(IStateMachine<T> stateMachine, T id)
		{
			this.id = id;
			this.stateMachine = stateMachine;
		}

        public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();

        public virtual void Dispose()
        {
            id = default(T);
            nextStateId = default(T);
            prevStateId = default(T);
            stateMachine = null;
            isDisposed = true;
        }      
	}
}


