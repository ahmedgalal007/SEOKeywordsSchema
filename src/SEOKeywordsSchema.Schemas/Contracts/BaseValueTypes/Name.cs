﻿using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;

namespace SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;
public class Name : ValueObject, IEquatable<Name>
{
    public const int MaxLength = 50;
    private Name(string value)
    {
        if (value.Length > MaxLength)
        {
            throw new ArgumentException(string.Format("Name shouldn't excced {0}", MaxLength));
        }
        Value = value;
    }
    public string Value { get; }

    public static Result<Name> Create(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Result.Failure<Name>(new Error(
                "Name.Empty",
                "Name is empty."));
        }
        if (name.Length > MaxLength)
        {
            return Result.Failure<Name>(new Error(
                "Name.TooLong",
                "Name is too long."));
        }
        return new Name(name);
    }

    public bool Equals(Name? other)
    {
        return Value.SequenceEqual(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return obj is Name name && name.Equals(this);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}