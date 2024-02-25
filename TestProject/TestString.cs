using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaProject;

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

    }
}
