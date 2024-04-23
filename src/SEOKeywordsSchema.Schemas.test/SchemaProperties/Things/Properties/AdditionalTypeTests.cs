using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;
using SEOKeywordsSchema.Schemas.Entities;
using SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;

namespace SEOKeywordsSchema.Schemas.test.SchemaProperties.Things.Properties
{
    [TestClass]
    public class AdditionalTypeTests
    {
        private MockRepository mockRepository;



        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private AdditionalType CreateAdditionalType()
        {
            return new AdditionalType(
                new Faker<Text>()
                    .RuleFor(c => c.Id, f => Guid.NewGuid())
                    .RuleFor(c => c.Value, f => f.Internet.Url())
            );
        }


        [TestMethod]
        [Priority(1)]
        public void additional_type_property_impilicit_assigne_test()
        {
            AdditionalType prop1 = new Text("http://ahmed.com");
            AdditionalType prop2 = new URL("http://ahmed.com");

            Assert.IsTrue(prop1.IsSingle && prop1.Value1.Count == 1, "The Text Must be single");
            Assert.IsTrue(prop1.Value1.First().Value == "http://ahmed.com", "Problem in Assignment to Text");
            Assert.IsTrue(prop1.Value2 == null || prop1.Value2.Count == 0, "URL Must Be null or have no members");
            Assert.IsTrue(prop2.IsSingle && prop2.Value2.Count == 1, "The URL Must be single");
            Assert.IsTrue(prop2.Value2.First().Value.AbsoluteUri == "http://ahmed.com/", "Problem in Assignment to URL");
            Assert.IsTrue(prop2 == "http://ahmed.com/", "Problem in Assignment to URL");
            Assert.IsTrue(prop2 == "http://ahmed.com/", "Problem in Assignment to URL Without Trailling");
            Assert.IsTrue(prop2.Value1 == null || prop2.Value1.Count == 0, "Text Must Be null or have no members");
        }

        [TestMethod]
        [Priority(2)]
        public void additional_type_property_check_text_equality_test()
        {
            AdditionalType prop1 = new Text("http://ahmed.com/");
            AdditionalType prop2 = new URL("http://ahmed.com/");

            Assert.IsTrue(prop1 == prop2, "The Text Must be single");
        }
    }
}
