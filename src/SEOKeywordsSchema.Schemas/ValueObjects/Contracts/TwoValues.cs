using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
using System.Collections;
using System.IO;
using System.Reflection.Emit;

namespace SEOKeywordsSchema.Schemas.ValueObjects.Contracts;

public class TwoValues<T1,T2> : ValueObjectWithId, IValues, IEquatable<object?>, IReadOnlyCollection<object?>, IEnumerable<object?>
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

    public Int32 Count => throw new NotImplementedException();

    public override Boolean Equals(Object? obj)
    {
        if(base.Equals(obj)) return true;
        //if (obj == null || obj.GetType() != GetType() || obj.GetType() != typeof(T1) || obj.GetType() != typeof(T2) || obj.GetType() != typeof(string))
        //    return false;
        if ((obj.GetType() == typeof(T1) || obj.GetType() == typeof(T2) || obj.GetType() == typeof(string)) )
        {
            return HasValue1 ? Value1.Equals(obj) : HasValue2 ? Value2.Equals(obj) : false;
        }
        //else if (obj.GetType() == typeof(T1) && !IsSingle)
        //{
        //    return Value1.Equals(obj);
        //}
        //else if (obj.GetType() == typeof(T2) && !IsSingle)
        //{
        //    return Value1.Equals(obj);
        //}
        return false;
    }

    protected override IEnumerable<Object> GetEqualityComponents()
    {
        yield return HasValue1;
        yield return Value1;
        yield return HasValue2;
        yield return Value2;
    }

    public override Int32 GetHashCode()
    {
        return HasValue1? Value1.GetHashCode(): HasValue2? Value2.GetHashCode(): GetHashCode();
    }

    public override String ToString()
    {
        string result = string.Empty;
        if (IsSingle) { 
            if(HasValue1)
            {
                result = Value1.First().ToString() ?? string.Empty;
            }else if(HasValue2)
            {
                result = Value2.First().ToString() ?? string.Empty;
            }
        }
        else
        {
            result = HasValue1? nameof(Value1) : nameof(Value2);
        }
        return result;
    }


    public IEnumerator GetEnumerator()
    {
        return HasValue1? Value1.GetEnumerator() : HasValue2? Value2.GetEnumerator() :throw new NullReferenceException(" Object Must Initialized With Value1 Or Value2");
    }

    IEnumerator<Object?> IEnumerable<Object?>.GetEnumerator()
    {
        return HasValue1 ? Value1.GetEnumerator() : HasValue2 ? Value2.GetEnumerator() : throw new NullReferenceException(" Object Must Initialized With Value1 Or Value2");
    }


    public static implicit operator TwoValues<T1, T2>(T1 value)
    {
        return new TwoValues<T1, T2>(value);
    }

    public static implicit operator TwoValues<T1, T2>(T2 value)
    {
        return new TwoValues<T1, T2>(value);
    }
}
