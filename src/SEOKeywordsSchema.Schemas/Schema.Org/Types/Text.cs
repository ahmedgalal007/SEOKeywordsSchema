﻿using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.SchemaEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Types;
// [Owned]
[EntityTypeConfiguration(typeof(TypeConfigurationBase<Text>))]
public class Text : BaseSchemaEntity, IValuesMember<Text>, ISchemaType<URL>,
                    IEquatable<Text>, IEquatable<URL>, IEquatable<string>
{
    protected Text() { }
    public Text(string value)
    {
        Value = value;
    }
    public string Value { get; set; } = string.Empty;
    public DefaultIdType Id { get; set; }
    Text? IValuesMember<DefaultIdType, Text>.Value { get; set; }

    //protected override IEnumerable<Text> GetEqualityComponents()
    //{
    //    yield return Value;
    //}
    public override bool Equals(object? obj)
    {
        if (base.Equals(obj)) return true;

        if (obj.GetType() == typeof(string))
            return string.Equals(Value, (string)obj);

        return false;
    }


    //public override int GetHashCode()
    //{
    //    //return Value.GetHashCode();
    //    return GetEqualityComponents()
    //        .Select(x => x != null ? x.GetHashCode() : 0)
    //        .Aggregate((x, y) => x ^ y);
    //}

    public bool Equals(Text? other)
    {
        return Id == other?.Id || Value == other?.Value;
    }

    public bool Equals(string? other)
    {
        return !string.IsNullOrEmpty(other) && !string.IsNullOrWhiteSpace(other) && Value == other;
    }

    public bool Equals(URL? other)
    {
        return other != null && other.Value?.AbsoluteUri?.TrimEnd('/').ToLower() == Value?.TrimEnd('/').ToLower();
    }

    public Text Update(Text value)
    {
        Value = value.Value;
        return this;
    }

    public Text? Delete(DefaultIdType id)
    {
        if (Id.Equals(id))
        {
            // Text result = new Text(Value);
            // result.Id = id;
            var result = (Text)MemberwiseClone();
            Value = string.Empty;
            // this.Id = default;
            return result;
        }
        return null;
    }

    public Boolean Equals(IValuesMember<DefaultIdType, Text>? other)
    {
        return Id == other?.Id && Value == other?.Value;
    }

    public static implicit operator Text(string value)
    {
        return new Text(value);
    }

    public static implicit operator Text(URL url)
    {
        return new Text(url.GetCleanUri());
    }

    public static bool operator ==(Text left, Text right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Text left, Text right)
    {
        return !left.Equals(right);
    }
}
