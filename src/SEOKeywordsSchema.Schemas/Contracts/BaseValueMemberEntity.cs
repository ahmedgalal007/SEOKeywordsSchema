using System.Collections;
using System.Collections.Generic;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
namespace SEOKeywordsSchema.Schemas.Contracts;

public class BaseValueMember<T> :  IValuesMember<T>
{
    protected BaseValueMember() { }// => Id = NewId.Next().ToGuid();

    public DefaultIdType Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public T? Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Boolean Equals(IValuesMember<DefaultIdType, T>? other)
    {
        return other?.Equals(this) ?? false;
    }

    public T Update(T? other)
    {
        Value = other;
        return this.Value;
    }



    //public Boolean Equals(IValuesMember<DefaultIdType, T>? other)
    //{
    //    if (ReferenceEquals(null, other)) return false;
    //    if (ReferenceEquals(this, other)) return true;
    //    return Equals(other.Id) && Equals(other.Value);
    //}

    //public Boolean Equals( T? other)
    //{
    //    if (ReferenceEquals(null, other)) return false;
    //    return Value.Equals(other) || other.Equals(Value);
    //}
    //public Boolean Equals(DefaultIdType other)
    //{
    //    if (ReferenceEquals(null, other) || other == default) return false;
    //    return Id.Equals(other) || other.Equals(Id);
    //}
}
