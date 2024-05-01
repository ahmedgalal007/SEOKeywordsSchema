
using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Extensions;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.TextObject;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Types.MixedTypes;
public class TextOrTextObject : BaseEntity, ITwoValues<Text, TextObject>, IEquatable<TextOrTextObject>, IEquatable<Text>, IEquatable<TextObject>, IEquatable<string>
{
    public List<Text> Value1 { get; set; }
    public List<TextObject> Value2 { get ; set; }

    public Int32 Count => (Value1?.Count ?? 0) + (Value2?.Count ?? 0);

    [NotMapped]
    public List<DomainEvent> DomainEvents { get; }


    protected TextOrTextObject() { }
    public TextOrTextObject(string value1) {
        Value1 ??= new List<Text>();
        Value1.Add(new Text(value1));
    }
    public TextOrTextObject(Text value1) {
        Value1 ??= new List<Text>();
        Value1.Add(value1);
    }
    public TextOrTextObject(TextObject value2) {
        Value2 ??= new List<TextObject>();
        Value2.Add(value2);
    }


    public bool Equals(TextOrTextObject? other)
    {
        return Equals((ITwoValues<Text, TextObject>?)other);
    }

    public Boolean Equals(Text? other)
    {
        return Count == 1 ? Value1.First().Value == other.Value : false;
    }

    public Boolean Equals(TextObject? other)
    {
        return Count == 1 ? Value2.First().Value == other.Value : false;
    }

    public Boolean Equals(String? other)
    {
        return Count == 1 ? Value1.First().Value.Equals(other) ||
                           Value2.First().Value.Equals(other) : false;
    }

    public IEnumerable<Object> GetEqualityComponents()
    {
        yield return Value1;
        yield return Value2;
    }

    public ITwoValues<Text, TextObject> Update(ITwoValues<Text, TextObject> other)
    {
        Update(other.Value1);
        Update(other.Value2);
        return this;
    }

    public ITwoValues<Text, TextObject> Update(List<Text>? listOfT1)
    {
        Value1.Update(listOfT1);
        return this;
    }

    public ITwoValues<Text, TextObject> Update(List<TextObject>? listOfT2)
    {
        Value2.Update(listOfT2);
        return this;
    }

    //public bool Equals(Text? other)
    //{
    //    if (IsSingle && HasValue1 && Count == 1)
    //    {
    //        return Value1.First().Equals(other);
    //    }
    //    return false;
    //}

    //public bool Equals(TextObject? other)
    //{
    //    if (IsSingle && HasValue2 && Count == 1)
    //    {
    //        return Value2.First().Equals(other);
    //    }
    //    return false;
    //}

    //public bool Equals(string? other)
    //{
    //    if (IsSingle && HasValue1)
    //    {
    //        return Value1.First().Equals(other);
    //    }
    //    else if (IsSingle && HasValue2)
    //    {
    //        return Value2.First().Equals(other);
    //    }
    //    return false;
    //}


}
