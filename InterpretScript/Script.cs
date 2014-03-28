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
            this.Result = string.Empty;
            this.Source = string.Empty;
            this.listINT = new List<INT>();
            this.listBOOL = new List<BOOL>();
            this.listFLOAT = new List<FLOAT>();
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

            // Compile source
            INT a = new INT(5);
            listINT.Add(a);
            INT b = new INT(5);
            listINT.Add(b);
            a += b;

            INT a1 = new INT(5);
            listINT.Add(a1);
            INT b1 = new INT(5);
            listINT.Add(b1);
            a1 -= b1;

            INT a2 = new INT(5);
            listINT.Add(a2);
            INT b2 = new INT(5);
            listINT.Add(b2);
            a2 *= b2;

            INT a3 = new INT(5);
            listINT.Add(a3);
            INT b3 = new INT(5);
            listINT.Add(b3);
            a3 /= b3;

            this.Result = a.Value.ToString() + "\n";
            this.Result += a1.Value.ToString() + "\n";
            this.Result += a2.Value.ToString() + "\n";
            this.Result += a3.Value.ToString() + "\n";
        }
    }
}
