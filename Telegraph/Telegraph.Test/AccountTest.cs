using Telegraph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegraph.Exceptions;

namespace Telegraph.Test
{
    [TestClass]
    public class AccountTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataRow("KvykTelegraphTest", null, null)]
        [DataRow("KvykTelegraphTest", "KvykTest", null)]
        [DataRow("KvykTelegraphTest", null, "https://github.io/")]
        [DataRow("KvykTelegraphTest", "KvykTest", "https://github.io/")]
        public async Task CreateAccount(string shortName, string authorName, string authorUrl)
        {
            try
            {
                var client = new TelegraphClient();
                var value = await client.CreateAccount(shortName, authorName, authorUrl);

                Assert.IsNotNull(value);
                Assert.IsNotNull(value.AccessToken);
                Assert.AreEqual(value.ShortName, shortName);
                Assert.AreEqual(value.AuthorName, authorName ?? string.Empty);
                Assert.AreEqual(value.AuthorUrl, authorUrl ?? string.Empty);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch(TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [DataRow("KvykTelegraphTestEdit", "KvykTestEdit", "https://github.io/edit")]
        [DataRow("KvykTelegraphTest", "KvykTest", "https://github.io/")]
        public async Task EditAccount(string shortName, string authorName, string authorUrl)
        {
            try
            {
                var client = new TelegraphClient(await CreateAccount());
                var value = await client.EditAccountInfo(shortName, authorName, authorUrl);

                Assert.IsNotNull(value);
                Assert.AreEqual(value.ShortName, shortName);
                Assert.AreEqual(value.AuthorName, authorName);
                Assert.AreEqual(value.AuthorUrl, authorUrl);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch(TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public async Task GetAccountInfo()
        {
            try
            {
                var client = new TelegraphClient(await CreateAccount());
                var value = await client.GetAccountInfo();

                Assert.IsNotNull(value);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch(TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public async Task RevokeAccessToken()
        {
            try
            {
                var token = await CreateAccount();
                var client = new TelegraphClient(token);
                var value = await client.RevokeAccessToken();

                Assert.IsNotNull(value);
                Assert.AreNotEqual(value.AccessToken, token);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch(TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }

        private async Task<string> CreateAccount()
        {
            var client = new TelegraphClient();

            //Flood error protection
            Thread.Sleep(250);

            var value = await client.CreateAccount("UnitTestUser");

            return value.AccessToken;
        }
    }
}
