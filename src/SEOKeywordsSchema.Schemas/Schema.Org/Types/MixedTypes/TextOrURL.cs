
using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Extensions;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Types.MixedTypes;
public class TextOrURL : BaseEntity, ITwoValues<Text, URL>, IEquatable<TextOrURL>, IEquatable<Text>, IEquatable<URL>, IEquatable<string>
{
    public List<Text> Value1 { get; set; }
    public List<URL> Value2 { get; set; }
    public Int32 Count => (Value1?.Count ?? 0) + (Value2?.Count ?? 0);

    [NotMapped]
    public List<DomainEvent> DomainEvents { get;  }

    protected TextOrURL() { }

    public TextOrURL(string value1)
    {
        Value1 ??= new List<Text>();
        Value1.Add(new Text(value1));
    }
    public TextOrURL(Text value1) 
    {
        Value1 ??= new List<Text>();
        Value1.Add(value1);
    }
    public TextOrURL(URL value2) 
    {
        Value2 ??= new List<URL>();
        Value2.Add(value2);
    }

    public ITwoValues<Text, URL> Update(ITwoValues<Text, URL> other)
    {
        Update(other.Value1);
        Update(other.Value2);
        return this;
    }

    public ITwoValues<Text, URL> Update(List<Text>? lisOfT1)
    {
        Value1.Update(lisOfT1);
        return this;
    }

    public ITwoValues<Text, URL> Update(List<URL>? listOfT2)
    {
        Value2.Update(listOfT2);
        return this;
    }


    IEnumerable<Object> ITwoValues<Text, URL>.GetEqualityComponents()
    {
        yield return Value1;
        yield return Value2;
    }

    public Boolean Equals(TextOrURL? other)
    {
        return Equals((ITwoValues<Text, URL>?)other);
    }

    public Boolean Equals(Text? other)
    {
        return Count == 1 ? Value1.First().Value == other.Value : false;
    }

    public Boolean Equals(URL? other)
    {
        return Count == 1 ? Value2.First().Value == other.Value : false;
    }

    public Boolean Equals(String? other)
    {
        return  Count == 1 ? Value1.First().Value.Equals(other) ||
                            Value2.First().Value.AbsoluteUri.Equals(other) : false;
    }

    





    //public bool Equals(TextOrURL? other)
    //{
    //    return Equals((TwoValues<Text, URL>?)other);
    //}

    //public Boolean Equals(Text? other)
    //{
    //    return Count == 1? Value1.First().Value == other.Value : false;
    //}

    //public Boolean Equals(URL? other)
    //{
    //    return Count == 1 ? Value2.First().Value == other.Value : false;
    //}

    //public Boolean Equals(String? other)
    //{
    //    return Count == 1 ? Value1.First().Value.Equals(other) || 
    //                        Value2.First().Value.AbsoluteUri.Equals(other) : false; 
    //}



    ///////////////////////////////////////////////////////////////////////////////////


    //protected override IEnumerable<object> GetEqualityComponents()
    //{
    //    return base.GetEqualityComponents();
    //}
    //private string GetSingleValue()
    //{
    //    return HasValue1 ? Value1.First().Value : HasValue2 ? Value2.First().Value.AbsoluteUri : string.Empty;
    //}

    //public bool Equals(Text? other)
    //{
    //    if (IsSingle && HasValue1 && Count == 1)
    //    {
    //        return Value1.First().Equals(other);
    //    }
    //    return false;
    //}

    //public bool Equals(URL? other)
    //{
    //    if (IsSingle && HasValue2 && Count == 1)
    //    {
    //        return Value2.First().Value.AbsoluteUri.Equals(other.Value.AbsoluteUri);
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
