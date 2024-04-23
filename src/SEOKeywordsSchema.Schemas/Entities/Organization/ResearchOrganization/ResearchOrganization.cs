using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Organizations;
public class ResearchOrganization : Organization
{
    public override string TypeName { get; protected set; } = nameof(ResearchOrganization);
}
