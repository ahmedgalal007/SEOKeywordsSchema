using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.StructuredValue;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.StructuredValue.EngineSpecification;
public class EngineSpecification : StructuredValue
{
    public override string TypeName { get; protected set; } = nameof(EngineSpecification);
}
