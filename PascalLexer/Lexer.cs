using System.Collections.Generic;
using Antlr4.Runtime;

namespace PascalLexer
{
    public class Lexer
    {
        public static IList<IToken> Lex(string input)
        {
            return new CommonTokenStream(new GrammarLexer(new AntlrInputStream(input))).GetTokens();
        }
    }
}