using NUnit.Framework;
using Bunit;



namespace BreakingBadApiTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using var context = new Bunit.TestContext();

            var component = context.RenderComponent<BrBadApi.Pages.Index>();

          component.Find("input");

          


        }

        [Test]
        public void Test2()
        {
            using var context = new Bunit.TestContext();

            var component = context.RenderComponent<BrBadApi.Pages.Index>();

            Assert.AreEqual("Search for a character: ", component.Find($"h5").TextContent);
           
        }

    }
}