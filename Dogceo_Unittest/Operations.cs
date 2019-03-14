using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dogceo_Unittest
{
    /// <summary>
    /// Shared operations for tests
    /// </summary>
    public static class Operations
    {
        public static string URL = "https://dog.ceo/api/breeds/list/all";
        public static string RetrieverURL = "https://dog.ceo/api/breed/retriever/list";
        public static string GoldenRetriver = "https://dog.ceo/api/breed/retriever/golden/images/random";

        /// <summary>
        /// Gets stream of the page from url
        /// </summary>
        /// <param name="url">url to use</param>
        /// <returns>string</returns>
        public static async Task<string> GetAll(string url)
        {
            string output = string.Empty;

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
            dynamic json = JObject.Parse(await GetAll(URL));

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
            string json = JObject.Parse(await GetAll(URL)).ToString();
            
            // Assert breed is in output
            Assert.IsTrue(json.Contains(breed));
        }

        /// <summary>
        /// Get Sub-Breed
        /// </summary>
        public  static async Task GetSubBreed()
        {
            // Get All dogs
            dynamic json = JObject.Parse(await GetAll(RetrieverURL));

            // Assert output is not null
            Assert.IsNotNull(json);

            // will show in output window of test(same as diagram 1)
            Console.WriteLine(json);
        }

        /// <summary>
        /// Get ramdom Image of GoldenRetriver
        /// </summary>
        public static async Task GetGoldenRetriverRandomImage()
        {
            // Get All dogs
            dynamic json = JObject.Parse(await GetAll(GoldenRetriver));

            // Assert output is not null
            Assert.IsNotNull(json);

            // will show in output window of test(same as diagram 1)
            Console.WriteLine(json);
        }
    }
}
