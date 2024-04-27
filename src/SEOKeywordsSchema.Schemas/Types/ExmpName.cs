using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;

namespace SEOKeywordsSchema.Schemas.Types;
public class ExmpName : ValueObject, 
                    IValuesMember<Text>, 
                    IEquatable<ExmpName>
{
    public const int MaxLength = 50;
    private ExmpName(string value)
    {
        if (value.Length > MaxLength)
        {
            throw new ArgumentException(string.Format("Name shouldn't excced {0}", MaxLength));
        }
        Value = value;
    }
    public string Value { get; }
    public DefaultIdType Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public static Result<ExmpName> Create(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Result.Failure<ExmpName>(new Error(
                "ExmpName.Empty",
                "ExmpName is empty."));
        }
        if (name.Length > MaxLength)
        {
            return Result.Failure<ExmpName>(new Error(
                "ExmpName.TooLong",
                "ExmpName is too long."));
        }
        return new ExmpName(name);
    }

    public Text Delete(DefaultIdType id)
    {
        throw new NotImplementedException();
    }

    public bool Equals(ExmpName? other)
    {
        return Value.SequenceEqual(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return obj is ExmpName name && name.Equals(this);
    }

    public Text Update(Text value)
    {
        throw new NotImplementedException();
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
