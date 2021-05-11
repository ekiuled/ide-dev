namespace PascalLexer
{
    public static class TokenType
    {
        public const int Number = Grammar.Number;
        public const int Identifier = Grammar.Identifier;
        public const int CharacterString = Grammar.CharacterString;
        public const int Comment = Grammar.Comment;
        public const int Whitespace = Grammar.Whitespace;
        public const int Eof = Grammar.Eof;
    }
}