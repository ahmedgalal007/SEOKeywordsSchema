
using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes;

namespace SEOKeywordsSchema.Schemas.SchemaProperties;
public class TextOrURL : TwoValues<Text, URL>, IEquatable<TextOrURL>, IEquatable<Text>, IEquatable<URL>, IEquatable<String>
{
    protected TextOrURL() { }
    public TextOrURL(Text value1) : base(value1)
    {
    }
    public TextOrURL(URL value2) : base(value2)
    {
    }

    protected override IEnumerable<Object> GetEqualityComponents()
    {
        return base.GetEqualityComponents();
    }
    private string GetSingleValue()
    {
        return HasValue1 ? Value1.First().Value : HasValue2 ? Value2.First().Value.AbsoluteUri : string.Empty;
    }

    public Boolean Equals(TextOrURL? other)
    {
        return base.Equals((TwoValues<Text,URL>?)other);
    }

    public Boolean Equals(Text? other)
    {
        if (IsSingle && HasValue1 && Count == 1) {
            return Value1.First().Equals(other); 
        }
        return false;
    }

    public Boolean Equals(URL? other)
    {
        if (IsSingle && HasValue2 && Count == 1)
        {
            return Value2.First().Equals(other);
        }
        return false;
    }

    public Boolean Equals(String? other)
    {
        if (IsSingle && ( HasValue1 ^ HasValue2 ) && Count == 1)
        {
            return Value2.First().Equals(other);
        }
        return false;
    }
    //public override Boolean Equals(object? obj)
    //{
    //    if (obj == null || obj.GetType() != GetType() || obj.GetType() != typeof(Text) || obj.GetType() != typeof(URL) || obj.GetType() != typeof(string))
    //        return false;
    //    if (obj.GetType() == typeof(string) && IsSingle)
    //        return  !string.IsNullOrWhiteSpace((string)obj) &&
    //                !string.IsNullOrWhiteSpace(GetSingleValue()) &&
    //                string.Equals(GetSingleValue(), (string)obj);
    //    return base.Equals(obj);
    //}
}
