using Kvyk.Telegraph.HTML;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Telegraph.HTML.Test
{
    [TestClass]
    public class HTMLTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public async Task TestMethod1()
        {
            var parser = new TelegraphHTML();

            var value = await parser.ParseHTMLAsync("<h1>Hello</h1><p>world! <b>bold</b> word</p> and one? </br> more test");

            TestContext.WriteLine(JsonConvert.SerializeObject(value));
        }
    }
}
