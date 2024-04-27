using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.StatusEnumerations;
public class LegalForceStatus : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(LegalForceStatus);
}


// TODO Member InForce
// TODO Member NotInForce
// TODO Member PartiallyInForce