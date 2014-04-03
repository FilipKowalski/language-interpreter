using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using InterpretScript.interpreter;

namespace InterpretScript.parser
{
    class Parser
    {
        string input;

        public Parser(string input)
        {
            this.input = input;
            removeWhiteSpaces();
        }
        
        /// <summary>
        /// Usuwa z wyrażenia białe spacje
        /// </summary>
        private void removeWhiteSpaces()
        {
            input = input.Replace(" ", "");
        }
        
        /// <summary>
        /// Metoda wywoławcza (jedyna publiczna), która przetwarza wyrażenie
        /// </summary>
        /// <returns></returns>
        public Expression parseExpression()
        {
            Expression exp = parseSum(0);
            return exp;
        }

        /// <summary>
        /// Parsuje działanie dodawania i odejmowania, ale wcześniej sprawdza czy nie ma operacji mnożenia
        /// </summary>
        /// <param name="position">Aktualna pozycja wskaźnika</param>
        /// <returns></returns>
        private Expression parseSum(int position)
        {
            Expression exp = parseMult(position);
            for (int i = position; i < input.Length; i++)
                if (input[i].ToString().Equals("+") || input[i].ToString().Equals("-"))
                    exp = new Binary_operator(input[i], exp, parseMult(i + 1));

            return exp;
        }

        /// <summary>
        /// Parsuje działanie mnożenia i dzielenia, ale wcześniej sprawdza z jaką wartością ma do czynienia
        /// </summary>
        /// <param name="position">Aktualna pozycja wskaźnika</param>
        /// <returns></returns>
        private Expression parseMult(int position)
        {
            Expression exp = parseTerm(position);
            for (int i = position; i < input.Length; i++)
                if (input[i].ToString().Equals("*") || input[i].ToString().Equals("/"))
                    exp = new Binary_operator(input[i], exp, parseTerm(i + 1));
                    
            return exp;
        }

        /// <summary>
        /// Parsuje pojedyńczy element. To znaczy sprawdza czy jest cyfra, zmienną lub poczatkiem nawiasu.
        /// </summary>
        /// <param name="position">Aktualna pozycja wskaźnika</param>
        /// <returns></returns>
        private Expression parseTerm(int position)
        {
            char c = input[position];
            if (Char.IsDigit(c))
                return parseConstant(position);
            else if (Char.IsLetter(c))
                return parseVariable(position);
            else if (c == '(')
                return parseParen(position);
            else
                return null;
        }

        /// <summary>
        /// Zwraca wartość stałej liczbowej.
        /// </summary>
        /// <param name="position">Aktualna pozycja wskaźnika</param>
        /// <returns></returns>
        private Expression parseConstant(int position)
        {
            string s = "";
            while ((position < input.Length) && Char.IsDigit(input[position])) {
                s += input[position].ToString();
                position++;
            }
            return new Constant(Int32.Parse(s));
        }

        /// <summary>
        /// Zwraca wartość zmiennej. 
        /// UWAGA : Póki co nie działa poprawnie z powodu braku predefiniowanych zmiennych.
        /// </summary>
        /// <param name="position">Aktualna pozycja wskaźnika</param>
        /// <returns></returns>
        private Expression parseVariable(int position)
        {
            string s = "";
            while ((position < input.Length) && Char.IsLetter(input[position]))
            {
                s += input[position];
                position++;
            }
            return new Variable(s);
        }

        /// <summary>
        /// Odczytuje początek i koniec nawiasu.
        /// UWAGA : Program źle oblicza koniec nawiasu z uwagi na to, że ma złe dane na temat wskaźnika.
        /// </summary>
        /// <param name="position">Aktualna pozycja wskaźnika</param>
        /// <returns></returns>
        private Expression parseParen(int position)
        {
            Expression exp = parseSum(position + 1);
            if(input[position + 1].Equals(')')) 
                return exp;

            return null;
        }
    }
}
