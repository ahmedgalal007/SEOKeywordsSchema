
using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.ValueObjects.Contracts;
using SEOKeywordsSchema.Schemas.Things.CreativeWorks.MediaObjects;

namespace SEOKeywordsSchema.Schemas.SchemaProperties;
public class TextOrTextObject : TwoValues<Text, TextObject>
{
    protected TextOrTextObject() { }
    public TextOrTextObject(Text value1) : base(value1)
    {
    }
    public TextOrTextObject(TextObject value2) : base(value2)
    {
    }
}
