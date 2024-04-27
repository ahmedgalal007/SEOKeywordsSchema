using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Role;
public class Role : Intangible
{
    public override string TypeName { get; protected set; } = nameof(Role);
}


// TODO LinkRole
// TODO OrganizationRole
// TODO PerformanceRole