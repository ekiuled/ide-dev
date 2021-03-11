using System;
using System.Collections.Generic;

namespace ExpressionParser
{
    public class Parser
    {
        private static readonly Dictionary<char, ushort> Precedence = new Dictionary<char, ushort>()
        {
            {'(', 0},
            {'+', 1},
            {'-', 1},
            {'*', 2},
            {'/', 2},
        };

        public static IExpression Parse(string text)
        {
            var operands = new Stack<IExpression>();
            var operators = new Stack<char>();

            foreach (var ch in text)
            {
                if (char.IsDigit(ch))
                {
                    operands.Push(new Literal(ch.ToString()));
                }
                else if (char.IsLetter(ch))
                {
                    operands.Push(new Variable(ch.ToString()));
                }
                else if (ch == '(')
                {
                    operators.Push(ch);
                }
                else if (ch == ')')
                {
                    while (operators.Count > 0 &&
                           operators.Peek() != '(')
                    {
                        Collapse(operands, operators);
                    }

                    Assert(operators.Count > 0 &&
                           operators.Peek() == '(' &&
                           operands.Count > 0);
                    operators.Pop();
                    operands.Push(new ParenExpression(operands.Pop()));
                }
                else if (Precedence.ContainsKey(ch))
                {
                    var precedence = Precedence[ch];
                    while (operators.Count > 0 &&
                           Precedence[operators.Peek()] >= precedence)
                    {
                        Collapse(operands, operators);
                    }

                    operators.Push(ch);
                }
                else
                {
                    throw new ArgumentException("Parse error");
                }
            }

            while (operators.Count > 0)
            {
                Collapse(operands, operators);
            }

            Assert(operands.Count == 1);
            return operands.Pop();
        }

        private static void Collapse(Stack<IExpression> operands, Stack<char> operators)
        {
            Assert(operands.Count >= 2);
            var rhs = operands.Pop();
            var lhs = operands.Pop();
            var op = operators.Pop();
            operands.Push(new BinaryExpression(lhs, rhs, op.ToString()));
        }

        private static void Assert(bool condition)
        {
            if (!condition)
            {
                throw new ArgumentException("Parse error");
            }
        }
    }
}