using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class StateC : State
    {
        public void change(Context context)
        {
            //Change state of context from C to A.
            context.state = new StateA();
            Console.WriteLine("Change state from C to A.");
        }
    }
}
