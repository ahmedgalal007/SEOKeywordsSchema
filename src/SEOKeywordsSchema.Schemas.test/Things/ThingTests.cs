using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SEOKeywordsSchema.Schemas.Persistence.Contexts;
using SEOKeywordsSchema.Schemas.SchemaProperties;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
using SEOKeywordsSchema.Schemas.test.Repositories;
using SEOKeywordsSchema.Schemas.Things;

namespace SEOKeywordsSchema.Schemas.test.Things
{
    [TestClass]
    public class ThingTests
    {
        private MockRepository mockRepository;

        private ThingRepository repo;


        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            // InMemory Database Options
            var optionsBuilder = new DbContextOptionsBuilder<SEOKeywordsSchemaDbContext>()
                                        .UseInMemoryDatabase(Guid.NewGuid().ToString());
            // Create the in memory database context
            var context = new SEOKeywordsSchemaDbContext(optionsBuilder.Options);

            // Create The Repository
             repo = new ThingRepository(context);
        }

        private Thing CreateThing()
        {
            Text name = new Text("My First Thing");
            TextOrURL txtOrUrl = new TextOrURL(name);
            URL url = new URL("http://microsoft.com");
            Image img = new Image(url);
            return Thing.Create("Test Schema", "Test Description", name, url.GetCleanUri(), img);
        }

        [TestMethod]
        public async Task Thing_AddTestThingToDatabase_ReturnThing()
        {
            // Arrange
            var thing = this.CreateThing();

            // Act
            thing = repo.Save(thing);
            var result = await repo.GetById(thing.Id);
            // Assert
            Assert.IsNotNull(result);
            this.mockRepository.VerifyAll();
        }
    }
}
