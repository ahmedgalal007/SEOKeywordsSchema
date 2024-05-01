using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Extensions;

namespace SEOKeywordsSchema.Schemas.Contracts.Interfaces;
public interface ITwoValues<T1,T2>
    where T1 : BaseSchemaEntity, IValuesMember<T1> //, IEquatable<T2>, IEquatable<ITwoValues<T1, T2>>
    where T2 : BaseSchemaEntity, IValuesMember<T2> //, IEquatable<T1>, IEquatable<ITwoValues<T1, T2>>
{
    List<T1> Value1 { get; set; }
    List<T2> Value2 { get; set; }

    public abstract IEnumerable<object> GetEqualityComponents();

    List<DomainEvent> DomainEvents { get; }
    public Int32 Count { get; }

    bool HasValue1 => Value1 != null && Value1.Count > 0;
    bool HasValue2 => Value2 != null && Value2.Count > 0;
    

    virtual bool IsSingle() {
        if((Value1 == null || Value1.Count() == 0) ^ (Value2 == null || Value2.Count() == 0)) return false;
        if (HasValue1 && Value1.Count() == 1 && (Value2 == null || Value2.Count() == 0)) return true;
        if (HasValue2 && Value2.Count() == 1 && (Value1 == null || Value1.Count() == 0)) return true;
        return false;
    }

    // bool Equales(T1 t1, T2 t2);
    // bool Equales(T1 t1);
    // bool Equales(T2 t2);

    public abstract ITwoValues<T1, T2> Update(ITwoValues<T1, T2> other);
    public abstract ITwoValues<T1, T2> Update(List<T1>? listOfT1);

    public abstract ITwoValues<T1, T2> Update(List<T2>? listOfT2);


    public virtual int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x != null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);
    }
    // static abstract bool operator ==(T1 t1);
    // static abstract bool operator !=(T1 t1);

}
