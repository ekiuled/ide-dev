using JetBrains.ReSharper.Plugins.Spring;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;

namespace JetBrains.ReSharper.Plugins.SpringTests
{
    [TestFixture]
    [TestFileExtension(".spring")]
    public class ParserTest : ParserTestBase<SpringLanguage>
    {
        protected override string RelativeTestDataPath => "parser";

        [TestCase("Pascal")]
        [Test]
        public void Test1(string filename)
        {
            DoOneTest(filename);
        }

        [TestCase("Pascal2")]
        [Test]
        public void Test2(string filename)
        {
            DoOneTest(filename);
        }

        [TestCase("Pascal3")]
        [Test]
        public void Test3(string filename)
        {
            DoOneTest(filename);
        }
    }
}