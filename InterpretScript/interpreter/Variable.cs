using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.interpreter
{
    class Variable : Expression
    {
        string name;

        public Variable(string name)
        {
            this.name = name;
        }

        public int getValue()
        {
            // pobrać ze słownika inta
            return 0;
        }
    }
}
