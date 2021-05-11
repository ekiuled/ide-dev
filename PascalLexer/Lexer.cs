using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;

namespace PascalLexer
{
    public static class Lexer
    {
        private class ThrowExceptionErrorListener : BaseErrorListener, IAntlrErrorListener<int>
        {
            public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line,
                int charPositionInLine,
                string msg, RecognitionException e)
            {
                throw new ArgumentException("Lexer error", msg, e);
            }
        }

        public static IEnumerable<IToken> Lex(string input)
        {
            var grammar = new Grammar(new AntlrInputStream(input));
            grammar.AddErrorListener(new ThrowExceptionErrorListener());
            var tokens = new CommonTokenStream(grammar);
            tokens.Fill();
            return tokens.GetTokens();
        }
    }
}