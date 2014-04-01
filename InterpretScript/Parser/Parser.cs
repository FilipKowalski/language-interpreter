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
        
        private void removeWhiteSpaces()
        {
            Regex.Replace(input, @"\s+", "");

        }
        
        private bool isEndOfLine()
        {
            foreach (char c in input)
                if (c.Equals(";"))
                    return true;
            
            return false;
        }

        public Expression parseExpression()
        {
            Expression exp = parseSum(0);
            return exp;
        }

        private Expression parseSum(int position)
        {
            Expression exp = parseMult(position);
            for (int i = position; i < input.Length; i++)
                if (input[i].ToString().Equals("+") || input[i].ToString().Equals("-"))
                    exp = new Binary_operator(input[i], exp, parseMult(i + 1));

            return exp;
        }

        private Expression parseMult(int position)
        {
            Expression exp = parseTerm(position);
            for (int i = position; i < input.Length; i++)
                if (input[i].ToString().Equals("*") || input[i].ToString().Equals("/"))
                    exp = new Binary_operator(input[i], exp, parseTerm(i + 1));
                    
            return exp;
        }

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

        private Expression parseConstant(int position)
        {
            string s = "";
            while ((position < input.Length) && Char.IsDigit(input[position])) {
                s += input[position].ToString();
                position++;
            }
            return new Constant(Int32.Parse(s));
        }

        private Expression parseVariable(int position)
        {
            string s = "";
            while (Char.IsLetter(input[position]))
            {
                position++;
                s += input[position];
            }
            return new Variable(s);
        }

        private Expression parseParen(int position)
        {
            position++;
            Expression exp = parseSum(position);
            if(input[position + 1].Equals(')')) 
                return exp;

            return null;
        }
    }
}
