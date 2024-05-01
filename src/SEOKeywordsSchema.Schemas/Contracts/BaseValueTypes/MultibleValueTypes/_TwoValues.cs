//using System.Collections;
//using System.ComponentModel.DataAnnotations.Schema;
//using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
//using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
//using SEOKeywordsSchema.Schemas.Extensions;


//namespace SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;

//public abstract class TwoValues<T1, T2> : ValueObject, IValuesProperty<TwoValues<T1, T2>>, IValues, IReadOnlyCollection<object?>, IEnumerable<object?>
//    where T1 : IValuesMember<T1>
//    where T2 : IValuesMember<T2>
//{

//    #region Constructors
//    /// Initializes a new instance of the <see cref="TwoValues"/> struct.
//    /// </summary>
//    /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
//    protected TwoValues() { }
//    public TwoValues(T1 value1)
//    {
//        Value1 ??= new List<T1>();
//        Value1.Add(value1);
//        Value2 = default;
//        HasValue1 = value1 is not null && Value1.Count > 0;
//        HasValue2 = false;
//        IsSingle = Value1.Count == 1;
//    }

//    /// <summary>
//    /// Initializes a new instance of the <see cref="TwoValues"/> struct.
//    /// </summary>
//    /// <param name="value">The value of type <typeparamref name="T2"/>.</param>
//    public TwoValues(T2 value2)
//    {
//        Value1 = default;
//        Value2 ??= new List<T2>();
//        Value2.Add(value2);
//        HasValue1 = false;
//        HasValue2 = value2 is not null && Value2.Count > 0;
//        IsSingle = Value2.Count == 1;
//    }

//    /// Initializes a new instance of the <see cref="TwoValues"/> struct.
//    /// </summary>
//    /// <param name="value">The value of type List<<typeparamref name="T1"/>>.</param>
//    public TwoValues(List<T1> value1)
//    {
//        Value1 = value1;
//        Value2 = default;
//        HasValue1 = value1 is not null && Value1.Count > 0;
//        HasValue2 = false;
//        IsSingle = Value1.Count == 1;
//    }

//    /// <summary>
//    /// Initializes a new instance of the <see cref="TwoValues"/> struct.
//    /// </summary>
//    /// <param name="value">The value of type List<<typeparamref name="T2"/>>.</param>
//    public TwoValues(List<T2> value2)
//    {
//        Value1 = default;
//        Value2 = value2;
//        HasValue1 = false;
//        HasValue2 = value2 is not null && Value2.Count > 0;
//        IsSingle = Value2.Count == 1;
//    }
//    #endregion

//    #region Properties
//    public DefaultIdType Id { get; set; }
//    public bool IsSingle { get; set; }

//    public bool HasValue1 { get; set; }
//    public List<T1> Value1 { get; set; }

//    public bool HasValue2 { get; set; }
//    public List<T2> Value2 { get; set; }

//    public int Count => GetCount();
//    #endregion
//    private int GetCount()
//    {
//        return HasValue1 ? Value1?.Count ?? 0 : HasValue2 ? Value2?.Count ?? 0 : 0;
//    }


//    public virtual TwoValues<T1, T2> Update(TwoValues<T1, T2> value)
//    {
//        if (IsSingle != value.IsSingle) IsSingle = value.IsSingle;
//        if (HasValue1 != value.HasValue1) HasValue1 = value.HasValue1;
//        if (HasValue2 != value.HasValue2) HasValue2 = value.HasValue2;

//        if (Value1 is not null && HasValue1 && Value1.Count > 0 && Value1 != value.Value1) Value1.Update(value.Value1);
//        if (Value2 is not null && HasValue2 && Value2.Count > 0 && Value2 != value.Value2) Value2.Update(value.Value2);

//        ClearOthersValues(value);
//        return this;
//    }

//    public void ClearOthersValues(TwoValues<T1, T2> val)
//    {

//        // Type type = val.HasValue1 ? val.Value1.GetType() : val.Value2.GetType();
//        if (HasValue1 && Value2 is not null) Value2.Clear();
//        if (HasValue2 && Value1 is not null) Value1.Clear();
//    }

//    public bool Equals(TwoValues<T1, T2>? other)
//    {
//        if (ReferenceEquals(null, other) ^ ReferenceEquals(null, this)) return false;
//        if (ReferenceEquals(this, other)) return true;
//        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
//    }



//    protected override IEnumerable<object> GetEqualityComponents()
//    {
//        yield return IsSingle;
//        yield return HasValue1;
//        yield return Value1;
//        yield return HasValue2;
//        yield return Value2;
//    }

//    public IEnumerator? GetEnumerator()
//    {
//        return HasValue1 ? Value1?.GetEnumerator() : HasValue2 ? Value2?.GetEnumerator() : throw new NullReferenceException(" Object Must Initialized With Value1 Or Value2");
//    }

//    IEnumerator<object?>? IEnumerable<object?>.GetEnumerator()
//    {
//        return GetEqualityComponents().GetEnumerator();
//    }

//    public override string ToString()
//    {
//        string result = string.Empty;
//        if (IsSingle)
//        {
//            if (HasValue1)
//            {
//                result = Value1?.First().ToString() ?? string.Empty;
//            }
//            else if (HasValue2)
//            {
//                result = Value2?.First().ToString() ?? string.Empty;
//            }
//        }
//        else
//        {
//            result = HasValue1 ?
//                     Value1?.Select(e => e.ToString()).ToString() ?? string.Empty :
//                     HasValue2 ?
//                     Value2?.Select(e => e.ToString()).ToString() ?? string.Empty :
//                     string.Empty;
//        }
//        return result;
//    }

//    public TwoValues<T1, T2> Delete(DefaultIdType id)
//    {
//        throw new NotImplementedException();
//    }

//    public static TwoValues<T1, T2> Create<U>(U value) 
//    {
//        throw new NotImplementedException();
//    }


//    static String IValuesProperty<DefaultIdType, TwoValues<T1, T2>>.Help() =>
//        @"";
//}



////public static implicit operator TwoValues<T1, T2>(T1 value)
////{
////    return new TwoValues<T1, T2>(value);
////}

////public static implicit operator TwoValues<T1, T2>(T2 value)
////{
////    return new TwoValues<T1, T2>(value);
////}

//// protected override object? GetSingleValue()
//// {
////     return HasValue1 ? Value1.First() : HasValue2 ? Value2.First() : false;
//// }

//// public override bool Equals(object? obj)
//// {
////     // if( (obj is the same type (TwoValues) and have the same reference) or have the same Id)
////     if (base.Equals(obj)) return true;

////     // 
////     if (obj.GetType() == typeof(TwoValues<T1, T2>) || obj.GetType() == typeof(T1) || obj.GetType() == typeof(T2) || obj.GetType() == typeof(string))
////     {
////         if (IsSingle)
////         {
////             return HasValue1 ? Value1.First().Equals(obj) : HasValue2 ? Value2.First().Equals(obj) : false;
////         }
////         else
////         {
////             if (HasValue1)
////             {
////                 var other = (List<T1>)obj;

////                 return Value1.SequenceEqual(other) || Value1.Except(other).ToList().Any();
////             }
////             else if (HasValue2)
////             {
////                 var other = (List<T2>)obj;
////                 return Value2.SequenceEqual(other) || Value2.Except(other).ToList().Any();
////             }
////         }
////     }
////     //else if (obj.GetType() == typeof(T1) && !IsSingle)
////     //{
////     //    return Value1.Equals(obj);
////     //}
////     //else if (obj.GetType() == typeof(T2) && !IsSingle)
////     //{
////     //    return Value1.Equals(obj);
////     //}
////     return false;
//// }