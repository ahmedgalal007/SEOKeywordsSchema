using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.NonprofitTypes;
public class UKNonprofitType : NonprofitType
{
    public override string TypeName { get; protected set; } = nameof(UKNonprofitType);
}


// TODO Member CharitableIncorporatedOrganization
// TODO Member LimitedByGuaranteeCharity
// TODO Member UKTrust
// TODO Member UnincorporatedAssociationCharity