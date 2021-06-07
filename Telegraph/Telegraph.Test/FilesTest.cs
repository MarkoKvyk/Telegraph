using Kvyk.Telegraph;
using Kvyk.Telegraph.Exceptions;
using Kvyk.Telegraph.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Telegraph.Test
{
    [TestClass]
    public class FilesTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public async Task UploadFiles()
        {
            try
            {
                var client = new TelegraphClient();

                var files = new List<FileToUpload>()
                {
                    new FileToUpload
                    {
                        Bytes = File.ReadAllBytes("Telegraph_logo.png"),
                        Type = "image/png"
                    }
                };

                var value = await client.UploadFiles(files);

                Assert.IsNotNull(value);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }
        
        [TestMethod]
        public async Task UploadFile()
        {
            try
            {
                var client = new TelegraphClient();

                var file = new FileToUpload
                {
                    Bytes = File.ReadAllBytes("Telegraph_logo.png"),
                    Type = "image/png"
                };

                var value = await client.UploadFile(file);

                Assert.IsNotNull(value);

                TestContext.WriteLine(JsonConvert.SerializeObject(value));
            }
            catch (TelegraphException e)
            {
                Assert.Fail(e.Message);
            }
        }

    }
}
