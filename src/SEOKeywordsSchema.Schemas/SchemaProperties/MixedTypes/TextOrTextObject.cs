
using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
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
