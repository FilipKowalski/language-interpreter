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
            AdvancedParser2 Parser = new AdvancedParser2(Source);

            /*List<Variables> ListVariables = new List<Variables>();
            ParserVariables parserVariables = new ParserVariables(ListVariables);
            parserVariables.ParseNewVariables("int a");
            parserVariables.ParseNewVariables("int b     =6");
            parserVariables.ParseNewVariables("int c=b");
            parserVariables.ParseNewVariables("float bb = 0.01");
            parserVariables.ParseNewVariables("float cc = bb*2");
            parserVariables.ParseNewVariables("double dd = 0.1");
            parserVariables.ParseNewVariables("double ee = dd*3");
            parserVariables.ParseVariables("a = b+c");

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

            


            } */
        this.Result = Parser.getResults();
        }
    }
}
