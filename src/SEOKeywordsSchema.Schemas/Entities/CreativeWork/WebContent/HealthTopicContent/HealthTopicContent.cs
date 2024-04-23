using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.WebContents;
public class HealthTopicContent : WebContent
{
    public override string TypeName { get; protected set; } = nameof(HealthTopicContent);
}

// TODO HealthTopicContent