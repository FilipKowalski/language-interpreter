using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.interpreter
{
    class Binary_operator : Expression
    {
        char symbol;
        Expression left, right;

        public Binary_operator()
        {

        }

        public Binary_operator(char symbol, Expression left, Expression right)
        {
            this.symbol = symbol;
            this.left = left;
            this.right = right;
        }

        public int getValue()
        {
            switch (symbol)
            {
                case '*': return left.getValue() * right.getValue();
                case '+': return left.getValue() + right.getValue();
                case '-': return left.getValue() - right.getValue();
                case '/': return left.getValue() / right.getValue();
            }
            return 0;
        }
    }
}
