using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.advanced_interpreter
{
    class WhileLoop : Program
    {
        Expression condition;
        Program body;

        public WhileLoop(Expression condition, Program body)
        {
            this.condition = condition;
            this.body = body;
        }

        public int getValue()
        {
            throw new NotImplementedException();
        }
    }
}
