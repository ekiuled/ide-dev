using System;
using NUnit.Framework;

namespace ExpressionParser.Tests
{
    public class Tests
    {
        private DumpVisitor _dumpVisitor;

        [SetUp]
        public void Setup()
        {
            _dumpVisitor = new DumpVisitor();
        }

        [Test]
        public void TestSingleLiteral()
        {
            Parser.Parse("1").Accept(_dumpVisitor);
            Assert.AreEqual("Literal(1)", _dumpVisitor.ToString());
        }

        [Test]
        public void TestSingleVariable()
        {
            Parser.Parse("X").Accept(_dumpVisitor);
            Assert.AreEqual("Variable(X)", _dumpVisitor.ToString());
        }

        [Test]
        public void TestInvalidExpressions()
        {
            Assert.Throws<ArgumentException>(() => Parser.Parse("+"));
            Assert.Throws<ArgumentException>(() => Parser.Parse("+0"));
            Assert.Throws<ArgumentException>(() => Parser.Parse("(a+b+)"));
            Assert.Throws<ArgumentException>(() => Parser.Parse("9/+23"));
            Assert.Throws<ArgumentException>(() => Parser.Parse("xyz"));
            Assert.Throws<ArgumentException>(() => Parser.Parse("2+2)"));
        }

        [Test]
        public void TestSingleOperator()
        {
            Parser.Parse("A*2").Accept(_dumpVisitor);
            Assert.AreEqual("Binary(Variable(A)*Literal(2))", _dumpVisitor.ToString());
        }

        [Test]
        public void TestPrecedence()
        {
            Parser.Parse("a+b*c*d-e/f*g").Accept(_dumpVisitor);
            Assert.AreEqual(
                "Binary(Binary(Variable(a)+Binary(Binary(Variable(b)*Variable(c))*Variable(d)))-Binary(Binary(Variable(e)/Variable(f))*Variable(g)))",
                _dumpVisitor.ToString());
        }

        [Test]
        public void TestBraces()
        {
            Parser.Parse("a*(b+c)").Accept(_dumpVisitor);
            Assert.AreEqual("Binary(Variable(a)*Paren(Binary(Variable(b)+Variable(c))))", _dumpVisitor.ToString());
        }
    }
}