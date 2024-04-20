using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.SoftwareApplications;
public class MobileApplication : SoftwareApplication
{
    public override string TypeName { get; protected set; } = nameof(MobileApplication);
}
