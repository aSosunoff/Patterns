using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.StatusState.Implementation
{
    public class CompletedState : State
    {
        public CompletedState() : base("Завершено")
        {
        }

        public override string Completed()
        {
            throw new NotImplementedException();
        }

        public override string Create()
        {
            throw new NotImplementedException();
        }

        public override string Delete()
        {
            throw new NotImplementedException();
        }

        public override string Read()
        {
            throw new NotImplementedException();
        }

        public override string Update()
        {
            throw new NotImplementedException();
        }
    }
}
