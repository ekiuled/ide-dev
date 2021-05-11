using System.Collections.Generic;
using Antlr4.Runtime;

namespace PascalLexer
{
    public static class Lexer
    {
        public static IEnumerable<IToken> Lex(string input)
        {
            var tokens = new CommonTokenStream(new Grammar(new AntlrInputStream(input)));
            tokens.Fill();
            return tokens.GetTokens();
        }
    }
}