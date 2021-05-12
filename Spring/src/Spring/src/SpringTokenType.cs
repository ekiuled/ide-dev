using System.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using JetBrains.Util;

namespace JetBrains.ReSharper.Plugins.Spring
{
    class SpringTokenType : TokenNodeType
    {
        public SpringTokenType(string s, int index) : base(s, index)
        {
        }

        public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
        {
            return new SpringToken(buffer.GetText(new TextRange(startOffset.Offset, endOffset.Offset)), this);
        }

        public override bool IsWhitespace => Index == PascalLexer.Whitespace;
        public override bool IsComment => Index == PascalLexer.Comment;
        public override bool IsStringLiteral => Index == PascalLexer.CharacterString;
        public override bool IsConstantLiteral => Index == PascalLexer.Number;
        public override bool IsIdentifier => Index == PascalLexer.Identifier;

        public override bool IsKeyword => new[]
        {
            PascalLexer.In, PascalLexer.Is,
            PascalLexer.Or, PascalLexer.Xor,
            PascalLexer.Div, PascalLexer.Mod, PascalLexer.And, PascalLexer.Shl, PascalLexer.Shr, PascalLexer.As,
            PascalLexer.Nil, PascalLexer.Begin, PascalLexer.End, PascalLexer.Goto, PascalLexer.Not,
            PascalLexer.Signum, PascalLexer.Case, PascalLexer.Of, PascalLexer.Else, PascalLexer.Otherwise,
            PascalLexer.If, PascalLexer.Then, PascalLexer.For, PascalLexer.To, PascalLexer.Downto, PascalLexer.Do,
            PascalLexer.Repeat, PascalLexer.Until, PascalLexer.While, PascalLexer.With
        }.Contains(Index);

        public override string TokenRepresentation => ToString();
    }

    class SpringToken : LeafElementBase
    {
        private readonly string _text;
        private readonly SpringTokenType _springTokenType;

        public SpringToken(string text, SpringTokenType springTokenType)
        {
            _text = text;
            _springTokenType = springTokenType;
        }

        public override int GetTextLength()
        {
            return _text.Length;
        }

        public override StringBuilder GetText(StringBuilder to)
        {
            return to.Append(_text);
        }

        public override IBuffer GetTextAsBuffer()
        {
            return new StringBuffer(_text);
        }

        public override string GetText()
        {
            return _text;
        }

        public override NodeType NodeType => _springTokenType;
        public override PsiLanguageType Language => SpringLanguage.Instance;
    }
}