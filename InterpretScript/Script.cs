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
            this.Result = string.Empty;
            this.Source = string.Empty;
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

            this.Result = Source;
        }
    }
}
