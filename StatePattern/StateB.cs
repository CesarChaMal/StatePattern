using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class StateB : State
    {
        public void change(Context context)
        {
            //Change state of context from B to C.
            context.state = new StateC();
            Console.WriteLine("Change state from B to C.");
        }
    }
}
