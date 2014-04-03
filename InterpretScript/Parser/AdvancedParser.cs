using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.parser
{
    class AdvancedParser
    {
        string input;
        string[] codeListArray;
        Dictionary<string, int> listInt = new Dictionary<string, int>();

        public AdvancedParser(string input)
        {
            this.input = input;
            splitIntoWords();
            scanForVariables();
        }

        /// <summary>
        /// Dzieli wpisany kod na oddzielne słowa i zapisuje do globalnej listy
        /// </summary>
        private void splitIntoWords()
        {
            input = input.Replace("/r/n", "");
            this.codeListArray = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Skanuje cały kod w poszukiwaniu zmiennych, które zapisuje do globalnej listy w postaci <klucz, wartość zmiennej>
        /// </summary>
        private void scanForVariables() {
            for (int i = 0; i < codeListArray.Length - 2; i++)
                if (!isSystemElement(codeListArray[i]) && codeListArray[i + 1].Equals("="))
                    listInt.Add(codeListArray[i], Int32.Parse(codeListArray[i + 2]));
        }
        
        /// <summary>
        /// Sprawdza, czy element przynależy do systemowych metod
        /// </summary>
        /// <param name="word">Przetwarza podane słowo</param>
        /// <returns></returns>
        private bool isSystemElement (string word) {
            if (word.Equals("if")) {
                return true;
            } else if (word.Equals("for")) {
                return true;
            }
            return false;
        }
    }
}