using Kvyk.Telegraph;
using Kvyk.Telegraph.Exceptions;
using Kvyk.Telegraph.HTML;
using Kvyk.Telegraph.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Telegraph.Test
{
    [TestClass]
    public class HTMLTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public async Task Parse()
        {
            var parser = new TelegraphHTML();

            var value = await parser.ParseHTMLAsync("<h1>Hello</h1><p>world! <b>bold</b> word</p> and one? </br> more test");

            TestContext.WriteLine(JsonConvert.SerializeObject(value));
        }

    }
}
