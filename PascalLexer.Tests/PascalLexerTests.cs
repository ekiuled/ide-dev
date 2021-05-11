using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace PascalLexer.Tests
{
    public class Tests
    {
        private static void AssertTokenType(List<string> inputs, int tokenType)
        {
            inputs.ForEach(input => CollectionAssert.AreEqual(
                new[] {tokenType, TokenType.Eof},
                Lexer.Lex(input).Select(t => t.Type)));
        }

        private static void AssertNotTokenType(List<string> inputs, int tokenType)
        {
            inputs.ForEach(input =>
            {
                try
                {
                    CollectionAssert.AreNotEqual(
                        new[] {tokenType, TokenType.Eof},
                        Lexer.Lex(input).Select(t => t.Type));
                }
                catch (ArgumentException)
                {
                }
            });
        }

        [Test]
        public void TestNumbers()
        {
            AssertTokenType(new List<string>
            {
                "123", "$abCd00eF2F1", "&17", "%111110100011", "0.313E1", "-0", "+%11"
            }, TokenType.Number);
            AssertNotTokenType(new List<string>
            {
                "+", "$", "&", "%", ".", "-", ".123", "NaN", "$0FG", "%2", "&8", "123E"
            }, TokenType.Number);
        }

        [Test]
        public void TestIdentifiers()
        {
            AssertTokenType(new List<string>
            {
                "_", "______", "a", "asd_asdnlUUUUbebnn1232313_", "_123", "g112"
            }, TokenType.Identifier);
            AssertNotTokenType(new List<string>
            {
                "123", ".", "_df?f"
            }, TokenType.Identifier);
        }

        [Test]
        public void TestCharacterStrings()
        {
            AssertTokenType(new List<string>
            {
                "''", "''''", "'This is a pascal string'", "'A tabulator character: '#9' is easy to embed'",
                "'the string starts here'#13#10'   and continues here'"
            }, TokenType.CharacterString);
            AssertNotTokenType(new List<string>
            {
                "'''", "'\\''", "'the string starts here \n and continues here'"
            }, TokenType.CharacterString);
        }

        [Test]
        public void TestComments()
        {
            AssertTokenType(new List<string>
            {
                "(* This is an old style comment *)",
                "{  This is a Turbo Pascal comment }",
                "// This is a Delphi comment. All is ignored till the end of the line. ",
                "{  \n My beautiful function  \n returns an interesting result. \n }",
                "{ Comment 1 (* comment 2 *) }",
                "(* Comment 1 { comment 2 } *)",
                "{ comment 1 // Comment 2 }",
                "(* comment 1 // Comment 2 *)",
                "// comment 1 (* comment 2 *)  ",
                "// comment 1 { comment 2 } "
            }, TokenType.Comment);
            AssertNotTokenType(new List<string>
            {
                " // Valid comment { No longer valid comment !! \n } ",
                "{ comment 1  (* comment 2 *   }",
                "// comment 1 { comment 2"
            }, TokenType.Comment);
        }
    }
}