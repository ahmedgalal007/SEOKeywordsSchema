using SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.NonprofitTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.NonprofitTypes.UKNonprofitTypes;
public class CharitableIncorporatedOrganization : UKNonprofitType
{
    public override string TypeName { get; protected set; } = nameof(CharitableIncorporatedOrganization);
}
