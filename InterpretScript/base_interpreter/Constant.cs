using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript
{
    class Constant : Expression
    {
        int value;

        public Constant(int value) {
            this.value = value;
        }

        /// <summary>
        /// Zwraca wartość stałej.
        /// </summary>
        /// <returns></returns>
        public int getValue()
        {
            return value;
        }
    }
}
