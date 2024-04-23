using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SEOKeywordsSchema.Schemas.Persistence.Contexts;
using SEOKeywordsSchema.Schemas.SchemaProperties;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
using System;

namespace SEOKeywordsSchema.Schemas.test.SchemaProperties.BaseMixedTypes
{
    [TestClass]
    public class TextOrURLTests
    {
        private MockRepository mockRepository;



        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            // InMemory Database Options
            var optionsBuilder = new DbContextOptionsBuilder<SEOKeywordsSchemaDbContext>()
                                        .UseInMemoryDatabase(Guid.NewGuid().ToString());
            // Create the in memory database context
            var context = new SEOKeywordsSchemaDbContext(optionsBuilder.Options);

        }

        private TextOrURL CreateTextOrURL(bool fromURL=false)
        {
            var txt = "http://google.com";
            return fromURL? new TextOrURL(new URL(txt)) : new TextOrURL(new Text(txt));
        }

        [TestMethod]
        public void Equals_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var textOrURL = this.CreateTextOrURL();
            TextOrURL? other = null;

            // Act
            var result = textOrURL.Equals(
                other);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void Equals_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var textOrURL = this.CreateTextOrURL();
            Text? other = null;

            // Act
            var result = textOrURL.Equals(
                other);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void Equals_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            var textOrURL = this.CreateTextOrURL();
            URL? other = null;

            // Act
            var result = textOrURL.Equals(
                other);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void Equals_StateUnderTest_ExpectedBehavior3()
        {
            // Arrange
            var textOrURL = this.CreateTextOrURL();
            String? other = null;

            // Act
            var result = textOrURL.Equals(
                other);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}
