using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.interpreter
{
    class Variable : Expression
    {
        string name;
        Dictionary<string, int> dictionaryInt;
        int value;

        public Variable(string name)
        {
            this.name = name;
        }

        public Variable(string name, Dictionary<string, int> dictionaryInt)
        {
            this.name = name;
            this.dictionaryInt = dictionaryInt;
        }

        /// <summary>
        /// Zwraca wartość zmiennej ze słownika.
        /// </summary>
        /// <returns></returns>
        public int getValue()
        {
            return dictionaryInt[name];
        }
    }
}
