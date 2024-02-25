using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaProject1;

namespace TestProject
{
    public class TestString
    {
        [Fact]
        public void TestTrimFirstCharacter()
        {
            string result = Program.TrimFirstCharacter("Hello World");
            Assert.Equal("ello orld", result);
        }
        [Fact]
        public void TestTrimLastCharacter()
        {
            string result = Program.TrimLastCharacter("Hello World");
            Assert.Equal("Hell Worl", result);
        }
        [Fact]
        public void TestToUpperCase()
        {
            var result = Program.ToUpperCase("Hello World");
            Assert.Equal("HELLO WORLD", result);
        }
        [Fact]
        public void TestReverseWordsOrder()
        {
            var result = Program.ReverseWordsOrder("Hello World");
            Assert.Equal("World Hello", result);
        }
        [Fact]
        public void TestReplaceCharacter()
        {
            var result = Program.ReplaceCharacter("Hello World",'l','x');
            Assert.Equal("Hexxo Worxd", result);
        }

    }
}
