using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
using System.Collections;
using System.IO;
using System.Net.WebSockets;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.ValueObjects.Contracts;

public abstract class TwoValues<T1, T2> : ValueObjectWithId, IValues, IReadOnlyCollection<object?>, IEnumerable<object?>
    where T1 : class
    where T2 : class
{
    protected TwoValues()
    {

    }

    /// Initializes a new instance of the <see cref="TwoValues"/> struct.
    /// </summary>
    /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
    public TwoValues(T1 value1)
    {
        Value1 ??= new List<T1>();
        Value1.Add(value1);
        Value2 = default;
        HasValue1 = value1 is not null && Value1.Count > 0;
        HasValue2 = false;
        IsSingle = Value1.Count == 1;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TwoValues"/> struct.
    /// </summary>
    /// <param name="value">The value of type <typeparamref name="T2"/>.</param>
    public TwoValues(T2 value2)
    {
        Value1 = default;
        Value2 ??= new List<T2>();
        Value2.Add(value2);
        HasValue1 = false;
        HasValue2 = value2 is not null && Value2.Count > 0;
        IsSingle = Value2.Count == 1;
    }


    public List<T1> Value1 { get; set; }
    public List<T2> Value2 { get; set; }

    public bool HasValue1 { get; set; }
    public bool HasValue2 { get; set; }
    public bool IsSingle { get; set; }

    public int Count => GetCount();

    private int GetCount()
    {
        return HasValue1 ? Value1.Count : HasValue2 ? Value2.Count : 0;
    }

    public Boolean Equals(TwoValues<T1,T2>? other)
    {
        if (ReferenceEquals(null, other) ^ ReferenceEquals(null, this)) return false;
        if (ReferenceEquals(this, other)) return true;
        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }
    //protected override object? GetSingleValue()
    //{
    //    return HasValue1 ? Value1.First() : HasValue2 ? Value2.First() : false;
    //}

    //public override bool Equals(object? obj)
    //{
    //    // if( (obj is the same type (TwoValues) and have the same reference) or have the same Id)
    //    if (base.Equals(obj)) return true;

    //    // 
    //    if (obj.GetType() == typeof(TwoValues<T1, T2>) || obj.GetType() == typeof(T1) || obj.GetType() == typeof(T2) || obj.GetType() == typeof(string))
    //    {
    //        if (IsSingle)
    //        {
    //            return HasValue1 ? Value1.First().Equals(obj) : HasValue2 ? Value2.First().Equals(obj) : false;
    //        }
    //        else
    //        {
    //            if (HasValue1)
    //            {
    //                var other = (List<T1>)obj;

    //                return Value1.SequenceEqual(other) || Value1.Except(other).ToList().Any();
    //            }
    //            else if (HasValue2)
    //            {
    //                var other = (List<T2>)obj;
    //                return Value2.SequenceEqual(other) || Value2.Except(other).ToList().Any();
    //            }
    //        }
    //    }
    //    //else if (obj.GetType() == typeof(T1) && !IsSingle)
    //    //{
    //    //    return Value1.Equals(obj);
    //    //}
    //    //else if (obj.GetType() == typeof(T2) && !IsSingle)
    //    //{
    //    //    return Value1.Equals(obj);
    //    //}
    //    return false;
    //}


    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return IsSingle;
        yield return HasValue1;
        yield return Value1;
        yield return HasValue2;
        yield return Value2;
    }

    // public override int GetHashCode()
    // {
    //     return HasValue1 ? Value1.GetHashCode() : HasValue2 ? Value2.GetHashCode() : GetHashCode();
    // }

    public override string ToString()
    {
        string result = string.Empty;
        if (IsSingle)
        {
            if (HasValue1)
            {
                result = Value1.First().ToString() ?? string.Empty;
            }
            else if (HasValue2)
            {
                result = Value2.First().ToString() ?? string.Empty;
            }
        }
        else
        {
            result = HasValue1 ? nameof(Value1) : nameof(Value2);
        }
        return result;
    }


    public IEnumerator GetEnumerator()
    {
        return HasValue1 ? Value1.GetEnumerator() : HasValue2 ? Value2.GetEnumerator() : throw new NullReferenceException(" Object Must Initialized With Value1 Or Value2");
    }

    IEnumerator<object?> IEnumerable<object?>.GetEnumerator()
    {
        return HasValue1 ? Value1.GetEnumerator() : HasValue2 ? Value2.GetEnumerator() : throw new NullReferenceException(" Object Must Initialized With Value1 Or Value2");
    }


    //public static implicit operator TwoValues<T1, T2>(T1 value)
    //{
    //    return new TwoValues<T1, T2>(value);
    //}

    //public static implicit operator TwoValues<T1, T2>(T2 value)
    //{
    //    return new TwoValues<T1, T2>(value);
    //}


}
