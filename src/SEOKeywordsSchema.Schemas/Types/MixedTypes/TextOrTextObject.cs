
using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.MediaObjects;
using SEOKeywordsSchema.Schemas.Types;

namespace SEOKeywordsSchema.Schemas.Types.MixedTypes;
public class TextOrTextObject : TwoValues<Text, TextObject>, IEquatable<TextOrTextObject>, IEquatable<Text>, IEquatable<TextObject>, IEquatable<string>
{
    protected TextOrTextObject() { }
    public TextOrTextObject(Text value1) : base(value1) { }
    public TextOrTextObject(TextObject value2) : base(value2) { }


    public bool Equals(TextOrTextObject? other)
    {
        return Equals((TwoValues<Text, TextObject>?)other);
    }

    public bool Equals(Text? other)
    {
        if (IsSingle && HasValue1 && Count == 1)
        {
            return Value1.First().Equals(other);
        }
        return false;
    }

    public bool Equals(TextObject? other)
    {
        if (IsSingle && HasValue2 && Count == 1)
        {
            return Value2.First().Equals(other);
        }
        return false;
    }

    public bool Equals(string? other)
    {
        if (IsSingle && HasValue1)
        {
            return Value1.First().Equals(other);
        }
        else if (IsSingle && HasValue2)
        {
            return Value2.First().Equals(other);
        }
        return false;
    }


}
