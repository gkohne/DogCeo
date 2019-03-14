using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace Dogceo_Unittest
{
    /// <summary>
    /// Shared operations for tests
    /// </summary>
    public static class Operations
    {
        public const string Url = "https://dog.ceo/api/breeds/list/all";
        public const string RetrieverUrl = "https://dog.ceo/api/breed/retriever/list";
        public const string GoldenRetriever = "https://dog.ceo/api/breed/retriever/golden/images/random";

        /// <summary>
        /// Gets stream of the page from url
        /// </summary>
        /// <param name="url">url to use</param>
        /// <returns>string</returns>
        static async Task<string> GetAll(string url)
        {
            string output;

            HttpClient httpClient = new HttpClient();
            Stream receiveStream = await httpClient.GetStreamAsync(new Uri(url));
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            output = readStream.ReadToEnd();

            httpClient.Dispose();

            return output;
        }

        /// <summary>
        /// Gets all breeds from url
        /// </summary>
        public static async Task GetAllBreeds()
        {
            // Get All dogs
            dynamic json = JObject.Parse(await GetAll(Url));

            // Assert output is not null
            Assert.IsNotNull(json);

            // will show in output window of test(same as diagram 1)
            Console.WriteLine(json);
        }

        /// <summary>
        /// verify breed exists
        /// </summary>
        /// <param name="breed">breed to verify</param>
        public  static async Task GetBreed(string breed)
        {
            // Get All dogs
            string json = JObject.Parse(await GetAll(Url)).ToString();
            
            // Assert breed is in output
            Assert.IsTrue(json.Contains(breed));
        }

        /// <summary>
        /// Get Sub-Breed
        /// </summary>
        public  static async Task GetSubBreed()
        {
            // Get All dogs
            dynamic json = JObject.Parse(await GetAll(RetrieverUrl));

            // Assert output is not null
            Assert.IsNotNull(json);

            // will show in output window of test(same as diagram 1)
            Console.WriteLine(json);
        }

        /// <summary>
        /// Get random Image of GoldenRetriever
        /// </summary>
        public static async Task GetGoldenRetrieverRandomImage()
        {
            // Get All dogs
            dynamic json = JObject.Parse(await GetAll(GoldenRetriever));

            // Assert output is not null
            Assert.IsNotNull(json);

            // will show in output window of test(same as diagram 1)
            Console.WriteLine(json);
        }
    }
}
