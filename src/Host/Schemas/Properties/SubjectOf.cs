using FSH.WebApi.Domain.Schemas.Properties;
using FSH.WebApi.Domain.Schemas.Things;
using Host.Common.ValueObjects;

namespace Host.Schemas.Properties;

public class SubjectOf : TwoValues<CreativeWork, Event>
{
    public SubjectOf()
    {
        
    }

    public SubjectOf(CreativeWork value1) : base(value1)
    {
    }
    public SubjectOf(Event value2) : base(value2)
    {
    }
}
