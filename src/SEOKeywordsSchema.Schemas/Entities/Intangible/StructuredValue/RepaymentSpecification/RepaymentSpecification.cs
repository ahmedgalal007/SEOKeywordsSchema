using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.StructuredValues;
public class RepaymentSpecification : StructuredValue
{
    public override string TypeName { get; protected set; } = nameof(RepaymentSpecification);
}
