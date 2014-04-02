using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.advanced_interpreter
{
    class If : Program
    {
        Program branchThen, branchElse;
        Expression condition;

        public If(Expression condition, Program branchThen, Program branchElse) {
            this.condition = condition;
            this.branchThen = branchThen;
            this.branchElse = branchElse;
        }
    }
}
