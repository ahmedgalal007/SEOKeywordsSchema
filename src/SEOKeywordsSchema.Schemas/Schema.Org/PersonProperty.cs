namespace SEOKeywordsSchema.Schemas.SchemaProperties;

public interface IPersonProperty : IProperty { }
public class PersonProperty : Property<IPersonProperty>
{
    protected PersonProperty(IPersonProperty value) : base(value)
    {
    }
}
