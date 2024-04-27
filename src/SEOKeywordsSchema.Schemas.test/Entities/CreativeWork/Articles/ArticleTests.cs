using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;

namespace SEOKeywordsSchema.Schemas.test.Entities.CreativeWork.Articles
{
    [TestClass]
    public class ArticleTests
    {
        private MockRepository mockRepository;



        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private Article CreateArticle()
        {
            return new Article();
        }

        [TestMethod]
        public void IsLeafe_ArticleClassIsLeaf_ReturnFalse()
        {
            // Arrange
            var article = this.CreateArticle();

            // Act
            var result = article.IsLeafe();

            // Assert
            Assert.IsFalse(result);
            this.mockRepository.VerifyAll();
        }
    }
}
