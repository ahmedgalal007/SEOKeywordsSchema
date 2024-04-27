using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.SoftwareApplication;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.SoftwareApplication.MobileApplication;
public class MobileApplication : SoftwareApplication
{
    public override string TypeName { get; protected set; } = nameof(MobileApplication);
}
