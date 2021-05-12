using System.Collections.Generic;
using Antlr4.Runtime;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace JetBrains.ReSharper.Plugins.Spring
{
    public struct SpringLexerState
    {
        public IToken Token;
        public int Type;
        public int Channel;
        public int Column;
        public int Line;
        public string Text;
        public bool HitEof;
        public int CurrentMode;
        public Stack<int> ModeStack;
    }

    public class SpringLexer : ILexer<SpringLexerState>
    {
        private readonly Lexer _lexer;
        private IToken _currentToken;

        public SpringLexer(IBuffer buffer)
        {
            Buffer = buffer;
            _lexer = new PascalLexer(new AntlrInputStream(buffer.GetText()));
        }

        public void Start()
        {
            Advance();
        }

        public void Advance()
        {
            _currentToken = _lexer.NextToken();
        }

        public SpringLexerState CurrentPosition
        {
            get => new SpringLexerState
            {
                Token = _lexer.Token,
                Type = _lexer.Type,
                Channel = _lexer.Channel,
                Column = _lexer.Column,
                Line = _lexer.Line,
                Text = _lexer.Text,
                HitEof = _lexer.HitEOF,
                CurrentMode = _lexer.CurrentMode,
                ModeStack = _lexer.ModeStack
            };
            set
            {
                _lexer.Token = value.Token;
                _lexer.Type = value.Type;
                _lexer.Channel = value.Channel;
                _lexer.Column = value.Column;
                _lexer.Line = value.Line;
                _lexer.Text = value.Text;
                _lexer.HitEOF = value.HitEof;
                _lexer.CurrentMode = value.CurrentMode;
                _lexer.ModeStack.Clear();
                foreach (var mode in value.ModeStack)
                {
                    _lexer.ModeStack.Push(mode);
                }
            }
        }

        object ILexer.CurrentPosition
        {
            get => CurrentPosition;
            set => CurrentPosition = (SpringLexerState) value;
        }

        public TokenNodeType TokenType =>
            _currentToken == null ? null : new SpringTokenType(_currentToken.Text, _currentToken.Type);

        public int TokenStart => _currentToken.StartIndex;
        public int TokenEnd => _currentToken.StopIndex + 1;
        public IBuffer Buffer { get; }
    }
}