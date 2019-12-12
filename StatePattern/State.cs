using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public interface State
    {
        void change(Context context);
    }
}
