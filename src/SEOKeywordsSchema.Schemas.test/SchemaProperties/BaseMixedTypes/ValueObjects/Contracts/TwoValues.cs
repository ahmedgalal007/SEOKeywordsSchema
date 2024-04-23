using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;
using SEOKeywordsSchema.Schemas.SchemaProperties;

namespace SEOKeywordsSchema.Schemas.test.SchemaProperties.BaseMixedTypes.ValueObjects.Contracts;
[TestClass]
public class TwoValues
{
    [TestMethod]
    public void TwoValues_check_reference_equalities_same_reference_Equales()
    {
        var Ref1 = new TextOrURL(new Text("aaaa"));
        var Ref2 = Ref1;

        Assert.IsTrue(Ref1.Equals(Ref2));
        Assert.IsTrue(Ref2.Equals(Ref1));
    }
    [TestMethod]
    public void TwoValues_check_reference_equalities_deferent_reference_NotEquales()
    {
        var Ref1 = new TextOrURL(new Text("aaaa"));
        var Ref2 = new TextOrURL(new Text("aaaa"));

        Assert.IsFalse(Ref1.Equals(Ref2));
        Assert.IsFalse(Ref2.Equals(Ref1));
    }

    [TestMethod]
    public void TwoValues_check_reference_equalities_same_Id_Equales()
    {
        Guid ID = Guid.NewGuid();
        var Ref1 = new TextOrURL(new Text("aaaa") { Id = ID });
        var Ref2 = new TextOrURL(new Text("bbbbb") { Id = ID });

        Assert.IsTrue(Ref1.Equals(Ref2));
        Assert.IsTrue(Ref2.Equals(Ref1));
    }
    [TestMethod]
    public void TwoValues_check_reference_equalities_same_Id_NotEquales()
    {
        Guid ID1 = Guid.NewGuid();
        Guid ID2 = Guid.NewGuid();
        var Ref1 = new TextOrURL(new Text("aaaa") { Id = ID1 });
        var Ref2 = new TextOrURL(new Text("bbbbb") { Id = ID2 }); ;

        Assert.IsFalse(Ref1.Equals(Ref2));
        Assert.IsFalse(Ref2.Equals(Ref1));
    }

//    [TestMethod]
//    public void TwoValues_check_value_equalities_text_to_Url_Equales()
//    {
//        var Val1 = new TwoValues<Text, URL>(new Text("http://microsoft.com"));
//        var Val2 = new TwoValues<Text, URL>(new URL("http://microsoft.com"));

//        Assert.IsTrue(Val1.Equals(Val2));
//    }

//    [TestMethod]
//    public void TwoValues_check_value_equalities_text_to_Url_NotEquales()
//    {
//        var Val1 = new TwoValues<Text, URL>(new Text("http://microsoft.com"));
//        var Val2 = new TwoValues<Text, URL>(new URL("http://microsoft.com"));

//        Assert.IsFalse(Val1.Equals(Val2));
//    }
}
