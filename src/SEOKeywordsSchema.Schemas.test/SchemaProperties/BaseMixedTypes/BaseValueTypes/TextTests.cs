using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;
using System;

namespace SEOKeywordsSchema.Schemas.test.SchemaProperties.BaseMixedTypes.BaseValueTypes
{
    [TestClass]
    public class TextTests
    {
        private MockRepository mockRepository;



        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private Text CreateText()
        {
            return new Text("abc123");
        }

        [TestMethod]
        public void Equals_ObjectReference_ReturnTrue()
        {
            // Arrange
            var text = this.CreateText();
            object? obj = text;

            // Act
            var result = text.Equals(obj);

            // Assert
            Assert.IsTrue(result);
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void GetHashCode_SameIfValuesEquals_ReturnTrue()
        {
            // Arrange
            Text text1 = this.CreateText();
            Text text2 = this.CreateText();
            // Act
            var result1 = text1.GetHashCode();
            var result2 = text2.GetHashCode();
            // Assert
            Assert.IsTrue( result1 != 0 && result2 != 0 && result1 == result2 );
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void Equals_ChangeValues_ReturnTrue()
        {
            // Arrange
            var text = this.CreateText();
            Text? other = text;
            string val2 = "123";
            other.Value = val2;

            // Act
            var result = text.Equals(other);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(text.Equals(val2), "Failed: String Variable Assignment To Text");
            Assert.IsTrue(text.Equals("123"), "Failed: String Text Assignment To Text");
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void Equals_ToStringWithTheSameValue_ReturnTrue()
        {
            // Arrange
            var text = this.CreateText();
            String? other = this.CreateText().Value;

            // Act
            var result = text.Equals(other);

            // Assert
            Assert.IsTrue(result);
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void Equals_ToUrlWithTheSameValue_ReturnTrue()
        {
            // Arrange
            var text = new Text("http://microsoft.com");
            URL? other = new URL(text.Value + '/');

            // Act
            var result = text.Equals(other);

            // Assert
            Assert.IsTrue(result);
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void ImplicitOperator_GenerateFromString_ReturnTrue()
        {
            // Arrange
            string init = "anyThingToTest";
            Text text = "anyThingToTest";

            // Act
            var result = text.Equals(init);

            // Assert
            Assert.IsTrue(result);
            this.mockRepository.VerifyAll();
        }
        [TestMethod]
        public void ImplicitOperator_GenerateFromURL_ReturnTrue()
        {
            // Arrange
            URL url = new URL("http://microsoft.com");
            Text text = url;

            // Act
            var result = text.Equals("http://microsoft.com") || text.Equals("http://microsoft.com/");

            // Assert
            Assert.IsTrue(result);
            this.mockRepository.VerifyAll();
        }
    }
}
