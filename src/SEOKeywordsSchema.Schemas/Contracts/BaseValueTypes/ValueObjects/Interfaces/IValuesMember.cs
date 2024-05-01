using SEOKeywordsSchema.Schemas.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;


public interface IValuesMember<T> : IValuesMember<DefaultIdType, T> { }
public interface IValuesMember<TID,T> : IEquatable<IValuesMember<TID,T>> 
{
    public TID Id { get; set; }
    public T? Value { get; set; }
    public virtual Int32 Count => (Value.GetType() is ICollection) ? ((ICollection)Value).Count : 1;

    protected static bool EqualOperator(IValuesMember<TID, T> left, IValuesMember<TID, T> right)
    {
        if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
        {
            return false;
        }
        return ReferenceEquals(left, right) || left.Equals(right);
    }

    protected static bool NotEqualOperator(IValuesMember<TID, T> left, IValuesMember<TID, T> right)
    {
        return !EqualOperator(left, right);
    }


    public abstract T Update(T? other);
    //public virtual IValuesMember<TID, T> Update(T? other)
    //{
    //    if (other.GetType() == GetType())
    //    {
    //        this.Value = ((IValuesMember<TID, T>)other).Value;
    //    }
    //    else if (other.GetType().IsAssignableFrom(GetType()))
    //    {
    //        this.Value = other;
    //    }
    //    return this;
    //}
    public virtual Boolean Equals(Object? other)
    {
        // return base.Equals(other);
        if (other is null) return false;
        if (other.GetType().Equals(GetType()))
            return EqualOperator(this, (IValuesMember<TID, T>)other);
        return false;
    }

    public virtual Boolean Equals(IValuesMember<DefaultIdType, T>? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Equals(other.Id) && Equals(other.Value);
    }

    public virtual Boolean Equals(T? other)
    {
        if (ReferenceEquals(null, other)) return false;
        return Value.Equals(other) || other.Equals(Value);
    }
    public virtual Boolean Equals(DefaultIdType other)
    {
        if (ReferenceEquals(null, other) || other == default) return false;
        return Id.Equals(other) || other.Equals(Id);
    }
}


