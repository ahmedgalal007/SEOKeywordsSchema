using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations;
public class BoardingPolicyType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(BoardingPolicyType);
}

// TODO GroupBoardingPolicy
// TODO ZoneBoardingPolicy