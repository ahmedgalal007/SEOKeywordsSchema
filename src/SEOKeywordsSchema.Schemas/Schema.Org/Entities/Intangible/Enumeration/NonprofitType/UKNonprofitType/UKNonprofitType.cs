using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType.UKNonprofitType;
public class UKNonprofitType : NonprofitType
{
    public override string TypeName { get; protected set; } = nameof(UKNonprofitType);
}


// TODO Member CharitableIncorporatedOrganization
// TODO Member LimitedByGuaranteeCharity
// TODO Member UKTrust
// TODO Member UnincorporatedAssociationCharity