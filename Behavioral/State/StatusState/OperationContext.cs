using System.Collections.Generic;
using State.StatusState.Implementation;

namespace State.StatusState
{
	public class OperationContext
	{
		private State _state;

		public OperationContext()
		{
			this.StateChange(new NewState());
		}

		public void StateChange(State state)
		{
			this._state = state;
			this._state.SetContext(this);
		}

		public List<string> GetListAvailablFunction()
		{
			return _state.GetListAvailablFunction();
		}

		public State GetState => _state;

		public string Completed()
		{
			return this._state.Completed();
		}

		public bool Close()
		{
			return this._state.Close();
		}

		public string Create()
		{
			return this._state.Create();
		}

		public string Update()
		{
			return this._state.Update();
		}

		public string Read()
		{
			return this._state.Read();
		}

		public string Delete()
		{
			return this._state.Delete();
		}
	}
}
