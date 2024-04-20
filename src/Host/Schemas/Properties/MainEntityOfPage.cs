using FSH.WebApi.Domain.Schemas.Properties;
using FSH.WebApi.Domain.Schemas.Things;
using Host.Common.ValueObjects;

namespace Host.Schemas.Properties;

public class MainEntityOfPage : TwoValues<CreativeWork, Uri>
{
    public MainEntityOfPage(CreativeWork value1) : base(value1)
    {
    }
    public MainEntityOfPage(Uri value2) : base(value2)
    {
    }
}
