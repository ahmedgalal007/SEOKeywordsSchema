using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using MassTransit;
namespace SEOKeywordsSchema.Schemas.Contracts;

public abstract class BaseSchemaEntity : BaseEntity<DefaultIdType>
{
    //protected BaseSchemaEntity() => Id = NewId.Next().ToGuid();

    public virtual string SchemaNameSpace() => GetType().Namespace
                                                    .TrimStart((Assembly.GetExecutingAssembly().GetName().Name! + ".").ToCharArray());
}
