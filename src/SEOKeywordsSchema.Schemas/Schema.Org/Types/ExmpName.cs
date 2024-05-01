using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Types;
public class ExmpName : BaseSchemaEntity, ISchemaType<URL>,
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
    Text? IValuesMember<DefaultIdType, Text>.Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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


    public override bool Equals(object? obj)
    {
        return obj is ExmpName name && name.Equals(this);
    }

    public Boolean Equals(IValuesMember<DefaultIdType, Text>? other)
    {
        throw new NotImplementedException();
    }

    public Boolean Equals(ExmpName? other)
    {
        throw new NotImplementedException();
    }

    public Text Update(Text value)
    {
        throw new NotImplementedException();
    }
}
