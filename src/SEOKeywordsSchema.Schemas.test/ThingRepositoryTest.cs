using Moq;
using Bogus;
using Host.Persistence.Contexts;
using FluentAssertions;
using SEOKeywordsSchema.Schemas.Things;
using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;


namespace SEOKeywordsSchema.Schemas.test;

[TestClass]
public class ThingRepositoryTest
{
    List<Thing> stub;

    [TestInitialize]
    public void Init()
    {
        stub = GenerateData(1);
        var data = stub.AsQueryable();
        var mockDbContext = new Mock<ApplicationDbContext>();
        var mockSet = new Mock<DbSet<Thing>>();
        mockSet.As<IQueryable<Thing>>().Setup(m => m.Provider).Returns(data.Provider);
        mockSet.As<IQueryable<Thing>>().Setup(m => m.ElementType).Returns(data.ElementType);
        mockSet.As<IQueryable<Thing>>().Setup(m => m.Expression).Returns(data.Expression);
        mockSet.As<IQueryable<Thing>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
        mockDbContext.Setup(x => x.Things).Returns(mockSet.Object);

        mockDbContext.Object.Things.Add(stub.FirstOrDefault());
    }

    [TestMethod]
    public void add_new_thing_test()
    {

    }

    //[TestMethod]
    //public void get_thing_namespace_test()
    //{
    //    stub = GenerateData(1);
    //    var data = stub.AsQueryable();
    //    string _namespace = data.First().SchemaNameSpace();
    //    Assert.IsNotNull(stub.FirstOrDefault());
    //}

    private List<Thing> GenerateData(int count)
    {
        var faker = new Faker<Thing>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.AdditionalType, f => new Text(f.Vehicle.Manufacturer()))
            .RuleFor(c => c.Description, f => f.Vehicle.Manufacturer())
            .RuleFor(c => c.DisambiguatingDescription, f => new Text(f.Vehicle.Model()))
            .RuleFor(c => c.Image, f => new Image(new URL(f.Image.LoremPixelUrl())))
            .RuleFor(c => c.SameAs, f => new URL("http://aaa.bbb"))
            .RuleFor(c => c.MainEntityOfPage, f => new MainEntityOfPage(new URL("http://ammm.com")))
            .RuleFor(c => c.PotentialAction, f => new URL("http://sss.com").ToString())
            // .RuleFor(c => c.SchemaNameSpace, f => (Func<string>)(() => "SEOKeywordsSchema.Schemas.Things"))
            .RuleFor(c => c.SubjectOf, f => new SubjectOf(new CreativeWork()));


        return faker.Generate(count);
    }
}