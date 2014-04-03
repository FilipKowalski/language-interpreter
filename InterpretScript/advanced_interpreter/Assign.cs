using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.advanced_interpreter
{
    class Assign : Program
    {
        string var;
        Expression exp;
        Dictionary<string, int> listInt = new Dictionary<string, int>();

        public Assign(string var, Expression exp)
        {
            this.var = var;
            this.exp = exp;
        }

        public int getValue()
        {

            return 0;
        }
    }
}
