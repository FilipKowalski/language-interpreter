using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpretScript.advanced_interpreter2;

namespace InterpretScript.parser
{
    class AdvancedParser2
    {
        string ifPattern = @"\Aif\(\w*\)\{\w*\}";
        string forPattern = @"\Afor\(\w*\)\{w*\}";
        string whilePattern = @"\Awhile\(\w*\)\{\w*\}";
        string expressionPattern = @"\w*;$";

        string input;
        string resultString = "";
        Dictionary<string, int> listInt = new Dictionary<string, int>();

        public AdvancedParser2(string input)
        {
            this.input = input;
            splitIntoPhrases();
        }
        ///<summary>
        ///Dzieli wpisany kod na wyrażenia if, while, rozdzielone średnikiem lub {} i zapisuje do listy
        /// </summary>
        public void splitIntoPhrases()
        {
            int start = 0;
            this.input = input.Replace("\r\n", "");
            this.input = input.Replace("\r", "");
            this.input = input.Replace("\n", "");
            this.input = input.Replace("\0","");
            this.input = input.Replace("\t", "");
            while (start < input.Length - 2)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(input.Substring(start, input.Length - start), ifPattern))
                {
                    start += System.Text.RegularExpressions.Regex.Matches(input.Substring(start, input.Length - start), ifPattern)[0].Length;
                    this.resultString += "if";
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(input.Substring(start, input.Length - start), forPattern))
                {
                    start += System.Text.RegularExpressions.Regex.Matches(input.Substring(start, input.Length - start), forPattern)[0].Length;
                    this.resultString += "for";
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(input.Substring(start, input.Length - start), whilePattern))
                {
                    start += System.Text.RegularExpressions.Regex.Matches(input.Substring(start, input.Length - start), whilePattern)[0].Length;
                    this.resultString += "while";
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(input.Substring(start, input.Length - start), expressionPattern))
                {
                    start += System.Text.RegularExpressions.Regex.Matches(input.Substring(start, input.Length - start), expressionPattern)[0].Length;
                    this.resultString += ";";
                }
                else
                {
                    this.resultString += "Błąd";
                    start = input.Length;
                }
             }
        }
        /// <summary>
        /// Zwraca komendy dla interpretera
        /// </summary>
        /// <returns></returns>
        public string getResults()
        {
            return this.resultString;
        }
    }
}