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
            this.Source = Source;
            this.Result = string.Empty;
            List<Variables> ListVariables = new List<Variables>();
            ParserVariables parserVariables = new ParserVariables(ListVariables);
            parserVariables.Parsing("int a = 5+7");
            parserVariables.Parsing("int b     =6");
            parserVariables.Parsing("int c=7");
            parserVariables.Parsing("int d");
            parserVariables.Parsing("bool a = true");
            parserVariables.Parsing("float bb = 0.01f");
            parserVariables.Parsing("double dd = 0.1");

            foreach(var list in ListVariables)
            {
                if (list.GetType() == "int")
                {
                    Parser parser = new Parser(list.Value);
                    Expression exp = parser.parseExpression();
                    list.Value = exp.getValue().ToString();
                }
                else if(list.GetType() == "bool")
                {

                }
                else if(list.GetType() == "float")
                {

                }
                else if(list.GetType() == "double")
                {

                }

                this.Result += list.GetType() + " " + list.Name + " = " + list.Value + "\n";
            }
        }
    }
}
