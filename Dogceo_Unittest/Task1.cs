using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dogceo_Unittest
{
    [TestClass]
    public class Task1
    {
        [TestMethod]
        public void GetAllDogBreeds()
        {
            Operations.GetAllBreeds().GetAwaiter().GetResult();
        }

        [TestMethod]
        public void GetRetriever()
        {
            Operations.GetBreed("retriever").GetAwaiter().GetResult();
        }

        [TestMethod]
        public void GetRetrieverSubBreed()
        {
            Operations.GetSubBreed().GetAwaiter().GetResult();
        }

        [TestMethod]
        public void GetGoldenRetrieverSubBreedRandomImage()
        {
            Operations.GetGoldenRetrieverRandomImage().GetAwaiter().GetResult();
        }

    }
}
