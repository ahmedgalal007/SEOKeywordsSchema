using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Extensions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;

public abstract class TwoValues<T1, T2> : BaseSchemaEntity, ITwoValues<T1, T2> where T1 : BaseSchemaEntity, IValuesMember<T1>
    where T2 : BaseSchemaEntity, IValuesMember<T2>
// where T1 : IValuesMember<T1>, IEquatable<T2>, IEquatable<ITwoValues<T1, T2>>
// where T2 : IValuesMember<T2>, IEquatable<T1>, IEquatable<ITwoValues<T1, T2>>
{


    #region Constructors
    /// Initializes a new instance of the <see cref="TwoValues"/> struct.
    /// </summary>
    /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
    protected TwoValues() { }
    public TwoValues(T1 value1)
    {
        Value1 ??= new List<T1>();
        Value1.Add(value1);
        Value2 = default;
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
    }

    /// Initializes a new instance of the <see cref="TwoValues"/> struct.
    /// </summary>
    /// <param name="value">The value of type List<<typeparamref name="T1"/>>.</param>
    public TwoValues(List<T1> value1)
    {
        Value1 = value1;
        Value2 = default;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TwoValues"/> struct.
    /// </summary>
    /// <param name="value">The value of type List<<typeparamref name="T2"/>>.</param>
    public TwoValues(List<T2> value2)
    {
        Value1 = default;
        Value2 = value2;
    }
    #endregion

    #region Properties
    public List<T1> Value1 { get; set; }
    public List<T2> Value2 { get; set; }
    public Int32 Count() => (Value1?.Count ?? 0) + (Value2?.Count ?? 0);
   
    [NotMapped]
    public List<DomainEvent> DomainEvents { get; }


    public IEnumerable<Object> GetEqualityComponents()
    {
        yield return Value1;
        yield return Value2;
    }
    Int32 ITwoValues<T1, T2>.Count => throw new NotImplementedException();
    #endregion

    #region Action Methods

    public virtual ITwoValues<T1, T2> Update(ITwoValues<T1, T2> other)
    {
        Update(other.Value1);   
        Update(other.Value2);
        return this;
    }

    public virtual ITwoValues<T1, T2> Update(List<T1>? lisOfT1)
        {
        if(lisOfT1 == null || lisOfT1.Count() == 0)
        {
            Value1 = null; // Value1.Except(Value1);
        }
        else
        {
            Value1.Update(lisOfT1.ToList());  
        }
        return this;
    }

    public virtual ITwoValues<T1, T2> Update(List<T2>? listOfT2)

    {
        if (listOfT2 == null || listOfT2.Count() == 0)
        {
            Value2 = null; //  Value2.Except(Value2);
        }
        else
        {
            Value2.Update(listOfT2.ToList());
        }
        return this;
    }

    





    #endregion


}


