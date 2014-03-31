using InterpretScript.interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript
{
    class Script
    {
        List<INT> listINT;
        List<BOOL> listBOOL;
        List<FLOAT> listFLOAT;
        string Result;
        string Source;

        public Script()
        {
            /*
            this.Result = string.Empty;
            this.Source = string.Empty;
            this.listINT = new List<INT>();
            this.listBOOL = new List<BOOL>();
            this.listFLOAT = new List<FLOAT>();
             */
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
            Expression exp = new Binary_operator('*', new Constant(2), new Constant(4));
            this.Result = exp.getValue().ToString();
            /*
            this.Source = Source;
            INT a = new INT("a", 5);
            listINT.Add(a);
            INT b = new INT("b", 5);
            listINT.Add(b);

            INT a1 = new INT("a1", 5);
            listINT.Add(a1);
            INT b1 = new INT("b1", 5);
            listINT.Add(b1);

            INT a2 = new INT("a2", 5);
            listINT.Add(a2);
            INT b2 = new INT("b2", 5);
            listINT.Add(b2);

            INT a3 = new INT("a3", 5);
            listINT.Add(a3);
            INT b3 = new INT("b3", 5);
            listINT.Add(b3);

            // +
            listINT.Single(u => u.Name == "a").Value += listINT.Single(u => u.Name == "b").Value;
            // -
            listINT.Single(u => u.Name == "a1").Value -= listINT.Single(u => u.Name == "b1").Value;
            // *
            listINT.Single(u => u.Name == "a2").Value *= listINT.Single(u => u.Name == "b2").Value;
            // /
            listINT.Single(u => u.Name == "a3").Value /= listINT.Single(u => u.Name == "b3").Value;

            this.Result = listINT.Single(u => u.Name == "a").Value.ToString() + "\n";
            this.Result += listINT.Single(u => u.Name == "a1").Value.ToString() + "\n";
            this.Result += listINT.Single(u => u.Name == "a2").Value.ToString() + "\n";
            this.Result += listINT.Single(u => u.Name == "a3").Value.ToString() + "\n";
             */
        }
    }
}
