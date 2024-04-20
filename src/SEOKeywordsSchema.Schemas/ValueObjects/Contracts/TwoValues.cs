namespace SEOKeywordsSchema.Schemas.ValueObjects.Contracts;

public abstract class TwoValues<T1,T2> : ValueObject
    where T1 : class 
    where T2 : class
{
    public TwoValues()
    {

    }
    public TwoValues(T1 value1)
    {
        Value1 ??= new List<T1>();
        Value1.Add(value1);
        Value2 = default;
        HasValue1 = value1 is not null && Value1.Count > 0;
        HasValue2 = false;
        IsSingle = Value1.Count == 1;
    }

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

    public override Boolean Equals(Object? obj)
    {
        return base.Equals(obj);
    }

    public override IEnumerable<Object> GetAtomicValues()
    {
        return HasValue1?Value1:Value2;
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
        return result;
    }
}
