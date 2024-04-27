using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.TextObject;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;
using SEOKeywordsSchema.Schemas.Schema.Org.Types.MixedTypes;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Properties.Thing;

[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<Description>))]
public class Description : TextOrTextObject, ISchemaProperty<Description>
{
    // public Description(string text):base(new Text(text)) {}
    protected Description() { }
    public Description(string value) : base(new Text(value)) { }
    public Description(Text value1) : base(value1) { }
    public Description(TextObject value2) : base(value2) { }


    public bool Equals(Description? other)
    {
        return Equals((TwoValues<Text, TextObject>?)other);
    }


    public static bool operator ==(Description? type, Text? txt)
    {
        if (type is null) return false;
        return type.Equals(txt);
    }
    public static bool operator !=(Description? type, Text? txt)
    {
        if (type is null) return true;
        return !type.Equals(txt);
    }


    public static bool operator ==(Description left, Description right)
    {
        if (ReferenceEquals(left, right)) return true;

        if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;

        return left.Equals(right);
    }
    public static bool operator !=(Description left, Description right)
    {
        if (ReferenceEquals(left, right)) return false;

        if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return true;

        return !left.Equals(right);
    }


    public static implicit operator Description(string value)
    {
        return new Description(value);
    }

    public static implicit operator Description(Text value)
    {
        return new Description(value);
    }

    public static implicit operator Description(TextObject value)
    {
        return new Description(value);
    }

}
