using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Roles;
public class LinkRole : Role
{
    public override string TypeName { get; protected set; } = nameof(LinkRole);
}
