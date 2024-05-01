using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;
using SEOKeywordsSchema.Schemas.Schema.Org.Types.MixedTypes;
using System;

namespace SEOKeywordsSchema.Schemas.test.Schema.Org.Types.MixedTypes
{
    [TestClass]
    public class TextOrURLTests
    {
        private MockRepository mockRepository;



        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private TextOrURL CreateTextOrURL(string str)
        {
            return new TextOrURL(new Text(str));
        }

        private TextOrURL CreateTextOrURL(Text  txt)
        {
            return new TextOrURL(txt);
        }

        private TextOrURL CreateTextOrURL(URL url)
        {
            return new TextOrURL(url);
        }

        [TestMethod]
        public void Equals_TextOrUrlWithSameValue_ExpectedBehavior()
        {
            // Arrange
            var textOrURL = CreateTextOrURL("http://microsoft.com/");
            TextOrURL? other = CreateTextOrURL("http://google.com/");

            // Act
            var result = textOrURL.Equals(
                other);

            // Assert
            Assert.IsTrue(result);
            this.mockRepository.VerifyAll();
        }

        [DataTestMethod]
        [DataRow("http://microsoft.com/")]
        [DataRow("Ahmed Galal")]
        public void Equals_CreatedFromTextEqualsToTextWithSameValue_ReturnTrue(string url)
        {
            // Arrange
            var textOrURL = this.CreateTextOrURL(new Text(url));
            Text? other = new Text(url);

            // Act
            var result = textOrURL.Equals(other);

            // Assert
            Assert.IsTrue(result);
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void Equals_CreatedFromURLEqualsToURLWithSameValue_ReturnTrue()
        {
            // Arrange
            var textOrURL = this.CreateTextOrURL(new URL("http://microsoft.com/"));
            URL? other = new URL("http://microsoft.com/");

            // Act
            var result = textOrURL.Equals(other);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("Abc123")]
        public void Equals_CreatedFromStringEqualsToStringWithSameValue_ReturnTrue(string str)
        {
            // Arrange
            var textOrURL = this.CreateTextOrURL(str);
            string? other = str;

            // Act
            var result = textOrURL.Equals(other);

            // Assert
            Assert.IsTrue(result);
            this.mockRepository.VerifyAll();
        }
    }
}
