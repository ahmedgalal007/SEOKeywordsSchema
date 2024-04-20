using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.StructuredValues;
public class OwnershipInfo : StructuredValue
{
    public override string TypeName { get; protected set; } = nameof(OwnershipInfo);
}
