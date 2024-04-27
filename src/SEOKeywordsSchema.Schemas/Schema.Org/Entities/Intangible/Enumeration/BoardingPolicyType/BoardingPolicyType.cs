using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.BoardingPolicyType;
public class BoardingPolicyType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(BoardingPolicyType);
}

// TODO GroupBoardingPolicy
// TODO ZoneBoardingPolicy