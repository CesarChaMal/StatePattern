using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class StateA : State
    {
        public void change(Context context)
        {
            //Change state of context from A to B.
            context.state = new StateB();
            Console.WriteLine("Change state from A to B.");
        }
    }
}
