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

            //this.Source = "int a = 5;\nint b = 2;\nint c = a + b;print(c);";

            AdvancedParser2 Parser = new AdvancedParser2(Source);
            //List<string> ListString = Parser.GetListSource();
            List<Variables> ListVariables = new List<Variables>();
            ParserVariables parserVariables = new ParserVariables(ListVariables);

            ParserTest ParserT = new ParserTest();
            List<string> ListString = new List<string>();
            ListString.Add("  int   a   =   5;");
            ListString.Add(" int   b   =   2;");
            ListString.Add("   printl  (  \"   tekst   \"  )  ;  ");
            ListString.Add("   printl  (  \"   a+b  \"  )  ;  ");
            ListString.Add("  printl   (  a   )  ;  ");
            ListString.Add("    a    =   6   ;  ");
            ListString.Add("printl  (  a  )    ;  ");
            ListString.Add("   a   =   a   +   b   ;  ");
            ListString.Add("  printl   (  a   )   ;");

            foreach(var list in ListString)
            {
                if(ParserT.CheckPrintText(list))
                {
                    this.Result += ParserT.GetPrintText(list);
                }
                else if(ParserT.CheckPrintVariables(list))
                {
                    string varT = ParserT.GetPrintVariables(list);
                    this.Result += ListVariables.Single(i => i.Name == varT).Value;
                }
                else if (ParserT.CheckPrintlText(list))
                {
                    this.Result += ParserT.GetPrintText(list)+"\n";
                }
                else if (ParserT.CheckPrintVariables(list))
                {
                    string varT = ParserT.GetPrintVariables(list);
                    this.Result += ListVariables.Single(i => i.Name == varT).Value;
                }
                else if (ParserT.CheckPrintlVariables(list))
                {
                    string varT = ParserT.GetPrintVariables(list);
                    this.Result += ListVariables.Single(i => i.Name == varT).Value+"\n";
                }
                else if(ParserT.CheckCreateVariable(list))
                {
                    parserVariables.ParseNewVariables(ParserT.GetCreateVariable(list));
                }
                else if(ParserT.CheckAttributeVariable(list))
                {
                    parserVariables.ParseVariables(ParserT.GetAttributeVariable(list));

                    string getName = ParserT.GetNameVariable(list);

                    Parser parser = new Parser(ListVariables.Single(i => i.Name == getName).Value);
                    Expression exp = parser.parseExpression();
                    ListVariables.Single(i => i.Name == getName).Value = exp.getValue().ToString();
                }
            }
        }
    }
}
