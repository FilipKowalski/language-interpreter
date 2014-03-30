using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.interpreter
{
    class Operator
    {
        char symbol;
        Expression left, right;

        public Operator(char s, Expression l, Expression r)
        {
            symbol = s;
            l = left;
            r = right;
        }
    }
}
