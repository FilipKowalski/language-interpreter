using InterpretScript.interpreter;
using InterpretScript.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript
{
    class Script
    {
        string Result;
        string Source;

        public Script()
        {

        }

        public string GetResult
        {
            get
            {
                return this.Result;
            }
        }

        public void RunScript(string Source)
        {
            //Expression exp = new Binary_operator('+', new Constant(2), new Variable("x"));
            this.Source = Source;
            Parser parser = new Parser(Source);
            Expression exp = parser.parseExpression();

            this.Result = exp.getValue().ToString();
        }
    }
}
