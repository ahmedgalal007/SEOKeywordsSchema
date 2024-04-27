using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.BoardingPolicyType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.BoardingPolicyType.GroupBoardingPolicy;
public class GroupBoardingPolicy : BoardingPolicyType
{
    public override string TypeName { get; protected set; } = nameof(GroupBoardingPolicy);
}
