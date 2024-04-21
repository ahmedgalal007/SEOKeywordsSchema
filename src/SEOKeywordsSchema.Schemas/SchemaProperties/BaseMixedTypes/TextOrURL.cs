
using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.OwnedBaseTypes;
using SEOKeywordsSchema.Schemas.ValueObjects.Contracts;

namespace SEOKeywordsSchema.Schemas.SchemaProperties;
public class TextOrURL : TwoValues<Text, URL>
{
    protected TextOrURL() { }
    public TextOrURL(Text value1) : base(value1)
    {
    }
    public TextOrURL(URL value2) : base(value2)
    {
    }

    private string GetSingleValue()
    {
        return HasValue1 ? Value1.First().Value : HasValue2 ? Value2.First().Value.AbsoluteUri : string.Empty;
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

[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<AdditionalType>))]
public class AdditionalType : TextOrURL {
    protected AdditionalType() {}
    public AdditionalType(Text value1) : base(value1){}
    public AdditionalType(URL value2) : base(value2){}

    public static implicit operator AdditionalType(Text value)
    {
        return new AdditionalType(value);
    }

    public static implicit operator AdditionalType(URL value)
    {
        return new AdditionalType(value);
    }
}