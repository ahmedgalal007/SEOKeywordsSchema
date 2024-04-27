using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Role;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Role.LinkRole;
public class LinkRole : Role
{
    public override string TypeName { get; protected set; } = nameof(LinkRole);
}
