using Telegraph;
using Telegraph.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegraph.Exceptions;
using Telegraph.Models;
using Node = Telegraph.Models.Node;

namespace Telegraph.Test
{
    [TestClass]
    public class PageTest
    {
        public TestContext TestContext { get; set; }

        public string TestAccessToken = "3a51947a49d5b5c329aa44d311f09d150329632bff1aec9a3bb0e557e57f";

        [TestMethod]
        [DataRow("Test page", null, null)]
        [DataRow("Test page", "Unit", null)]
        [DataRow("Test page", null, "https://github.io/")]
        [DataRow("Test page", "Unit", "https://github.io/")]
        public async Task CreatePage(string title, string authorName, string authorUrl)
        {
            var nodes = new List<Node>()
            {
                Node.H3("Test header"),
                Node.P("Hello, World!"),
                Node.ImageFigure("https://telegra.ph/images/logo.png", "Logo"),
            };

            try
            {
                var client = new TelegraphClient(await CreateAccount());
                var value = await client.CreatePage(title, nodes, authorName, authorUrl);

                Assert.IsNotNull(value);
                Assert.AreEqual(title, value.Title);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }
        
        [TestMethod]
        [DataRow("Test page2", null, null)]
        [DataRow("Test page2", "Unit", null)]
        [DataRow("Test page2", null, "https://github.io/")]
        [DataRow("Test page2", "Unit", "https://github.io/")]
        public async Task EditPage(string title, string authorName, string authorUrl)
        {
            var nodes = new List<Node>()
            {
                Node.H3("Test header 2"),
                Node.P("Hello, World!"),
                Node.ImageFigure("https://telegra.ph/images/logo.png", "Logo"),
            };

            try
            {
                var client = new TelegraphClient(await CreateAccount());

                var path = (await client.CreatePage("test", nodes)).Path;
                var value = await client.EditPage(path, title, nodes, authorName, authorUrl);

                Assert.IsNotNull(value);
                Assert.AreEqual(title, value.Title);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [DataRow("https://telegra.ph/Test-page-06-07-22")]
        [DataRow("Test-page-06-07-22")]
        public async Task GetPage(string path)
        {
            try
            {
                var client = new TelegraphClient();
                var value = await client.GetPage(path);

                Assert.IsNotNull(value);
                Assert.IsNotNull(value.Content);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public async Task GetPageList()
        {
            try
            {
                var client = new TelegraphClient(await CreateAccount());
                var value = await client.GetPageList();

                Assert.IsNotNull(value);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }
        
        [TestMethod]
        [DataRow("Test-page-06-07-22", 2021, 6, 7, 12)]
        public async Task GetViews1(string path, int year, int month, int day, int hour)
        {
            try
            {
                var client = new TelegraphClient();
                var value = await client.GetViews(path, year, month, day, hour);

                Assert.IsNotNull(value);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }
        
        [TestMethod]
        [DataRow("Test-page-06-07-22", 2021, 6, 7)]
        public async Task GetViews2(string path, int year, int month, int day)
        {
            try
            {
                var client = new TelegraphClient();
                var value = await client.GetViews(path, year, month, day);

                Assert.IsNotNull(value);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }
        
        [TestMethod]
        [DataRow("Test-page-06-07-22", 2021, 6)]
        public async Task GetViews3(string path, int year, int month)
        {
            try
            {
                var client = new TelegraphClient();
                var value = await client.GetViews(path, year, month);

                Assert.IsNotNull(value);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }
        
        [TestMethod]
        [DataRow("Test-page-06-07-22", 2021)]
        public async Task GetViews4(string path, int year)
        {
            try
            {
                var client = new TelegraphClient();
                var value = await client.GetViews(path, year);

                Assert.IsNotNull(value);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }
        
        [TestMethod]
        [DataRow("Test-page-06-07-22")]
        public async Task GetViews5(string path)
        {
            try
            {
                var client = new TelegraphClient();
                var value = await client.GetViews(path);

                Assert.IsNotNull(value);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }

        private async Task<string> CreateAccount()
        {
            var client = new TelegraphClient();
            var value = await client.CreateAccount("UnitTestUser");
            return value.AccessToken;
        }
    }
}
