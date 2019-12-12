using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Context object and suplied current state or initial state (state A).
            Context context = new Context(new StateA());

            //Change state request from A to B.
            context.Request();

            //Change state request from B to C.
            context.Request();

            //Change state request from C to A.
            context.Request();
        }
    }
}
