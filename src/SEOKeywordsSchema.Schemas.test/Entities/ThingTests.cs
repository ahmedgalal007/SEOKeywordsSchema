using Microsoft.EntityFrameworkCore;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SEOKeywordsSchema.Schemas.Persistence.Contexts;
using SEOKeywordsSchema.Schemas.test.Repositories;
using SEOKeywordsSchema.Schemas.SchemaEntities;
using SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;
using SEOKeywordsSchema.Schemas.Types;
using SEOKeywordsSchema.Schemas.Types.MixedTypes;
using Action = SEOKeywordsSchema.Schemas.SchemaEntities.Action;

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
            Identifier identifier = new Identifier("Test Schema");
            Description description = "Test Description";
            Name name = new Name("My First Thing");
            TextOrURL txtOrUrl = new TextOrURL(name.First());
            URL url = new URL("http://microsoft.com");
            Image img = new Image(url);
            PotentialAction potentialAction = new PotentialAction( new Action());
            return Thing.Create(identifier, description, name, url.GetCleanUri(), img, potentialAction);
        }

        [TestMethod]
        public async Task Thing_AddTestThingToDatabase_ReturnThing()
        {
            // Arrange
            var thing = this.CreateThing();

            // Act
            // thing = await repo.SaveAsync(thing);
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
            thing = await repo.SaveAsync(thing);
            Thing? result = await repo.GetById(thing.Id);


            // Act
            result?.Update(null, "Ahmed Galal 2024",null,null);
            await repo.UpdateAsync(result);

            thing = await repo.GetById(result.Id);
            // Assert
            Assert.IsTrue(thing?.Name?.First()?.Value?.Equals("Ahmed Galal 2024") ?? false);
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public async Task Thing_UpdateThingDescriptionWithStringToDatabase_ReturnNameEqualsNewName()
        {
            // Arrange
            Thing? thing = this.CreateThing();
            thing = await repo.SaveAsync(thing);
            Thing? result = await repo.GetById(thing.Id);


            // Act
            result?.Update("Description of the first thing in schema", null, null, null);
            await repo.UpdateAsync(result);

            thing = await repo.GetById(result.Id);
            // Assert
            Assert.IsTrue(thing?.Description?.Value1?.First()?.Value.Equals("Description of the first thing in schema") ?? false);
            this.mockRepository.VerifyAll();
        }
    }
}
