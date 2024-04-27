using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.SoftwareApplication;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.SoftwareApplication.WebApplication;
public class WebApplication : SoftwareApplication
{
    public override string TypeName { get; protected set; } = nameof(WebApplication);
}
