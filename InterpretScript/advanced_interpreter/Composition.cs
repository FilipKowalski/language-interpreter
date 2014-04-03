using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.advanced_interpreter
{
    class Composition : Program
    {
        Program left, right;

        Composition(Program left, Program right)
        {
            this.left = left;
            this.right = right;
        }

        public int getValue()
        {
            throw new NotImplementedException();
        }
    }
}
