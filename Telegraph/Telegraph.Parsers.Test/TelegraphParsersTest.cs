using Kvyk.Telegraph.Parsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Telegraph.Parsers.Test
{
    [TestClass]
    public class TelegraphParsersTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public async Task ParseHTML()
        {
            var parser = new TelegraphHTML();

            var value = await parser.ParseHTMLAsync("<h1>Hello</h1><p>world! <b>bold</b> word</p> and one? </br> more test");

            TestContext.WriteLine(JsonConvert.SerializeObject(value));
        }

        [TestMethod]
        public async Task ParseMarkdown()
        {
            var parser = new TelegraphMarkdown();

            var value = await parser.ParseMarkdownAsync(
@"# Hello
## Hello2
World **LOL**
1. one
1. two
1. three
---
        "
            );

            TestContext.WriteLine(JsonConvert.SerializeObject(value));
        }
    }
}
