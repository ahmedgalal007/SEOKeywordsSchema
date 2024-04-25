using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;
using SEOKeywordsSchema.Schemas.Persistence.Contexts;
using SEOKeywordsSchema.Schemas.SchemaProperties;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes;
using SEOKeywordsSchema.Schemas.test.Repositories;
using SEOKeywordsSchema.Schemas.Entities;

namespace SEOKeywordsSchema.Schemas.test.Entities
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

        [TestMethod]
        public async Task Thing_UpdateThingNameWithStringToDatabase_ReturnNameEqualsNewName()
        {
            // Arrange
            Thing? thing = this.CreateThing();
            thing = repo.Save(thing);
            Thing? result = await repo.GetById(thing.Id);


            // Act
            result?.Update(null,"Ahmed Galal 2024",null,null);
            repo.Save(result);

            thing = await repo.GetById(result.Id);
            // Assert
            Assert.Equals(thing.Name, "Ahmed Galal 2024");
            this.mockRepository.VerifyAll();
        }
    }
}
