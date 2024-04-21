using System.ComponentModel.DataAnnotations.Schema;
using MassTransit;
namespace SEOKeywordsSchema.Schemas.Contracts;

public abstract class BaseSchemaEntity : BaseEntity<DefaultIdType>
{
    protected BaseSchemaEntity() => Id = NewId.Next().ToGuid();
}
