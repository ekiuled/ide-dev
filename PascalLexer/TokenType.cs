namespace PascalLexer
{
    public static class TokenType
    {
        public const int Number = Grammar.Number;
        public const int Identifier = Grammar.Identifier;
        public const int CharacterString = Grammar.CharacterString;
        public const int Comment = Grammar.Comment;
        public const int Symbol = Grammar.Symbol;

        public const int Semicolon = Grammar.Semicolon;
        public const int LBrace = Grammar.LBrace;
        public const int RBrace = Grammar.RBrace;
        public const int Eop = Grammar.Eop;

        public const int Whitespace = Grammar.Whitespace;
        public const int Eof = Grammar.Eof;
        public const int Error = Grammar.Error;
    }
}