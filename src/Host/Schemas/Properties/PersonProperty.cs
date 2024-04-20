using FSH.WebApi.Domain.Schemas.Properties;

namespace Host.Schemas.Properties;

public interface IPersonProperty : IProperty { }
public class PersonProperty : Property<IPersonProperty>
{
    protected PersonProperty(IPersonProperty value) : base(value)
    {
    }
}
