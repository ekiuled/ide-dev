using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace PascalLexer.Tests
{
    public class Tests
    {
        [Test]
        public void TestNumbers()
        {
            new List<string>
            {
                "123", "$abCd00eF2F1", "&17", "%111110100011", "0.313E1", "-0", "+%11"
            }.ForEach(input => CollectionAssert.AreEqual(
                new[] {TokenType.Number, TokenType.Eof},
                Lexer.Lex(input).Select(t => t.Type)));
        }

        [Test]
        public void TestIdentifiers()
        {
            new List<string>
            {
                "_", "______", "a", "asd_asdnlUUUUbebnn1232313_", "_123", "g112"
            }.ForEach(input => CollectionAssert.AreEqual(
                new[] {TokenType.Identifier, TokenType.Eof},
                Lexer.Lex(input).Select(t => t.Type)));
        }

        [Test]
        public void TestCharacterStrings()
        {
            new List<string>
            {
                "''", "''''", "'This is a pascal string'", "'A tabulator character: '#9' is easy to embed'",
                "'the string starts here'#13#10'   and continues here'"
            }.ForEach(input => CollectionAssert.AreEqual(
                new[] {TokenType.CharacterString, TokenType.Eof},
                Lexer.Lex(input).Select(t => t.Type)));
        }
    }
}