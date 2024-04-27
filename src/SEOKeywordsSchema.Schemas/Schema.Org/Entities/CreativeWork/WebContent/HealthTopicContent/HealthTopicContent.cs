using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.WebContent;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.WebContent.HealthTopicContent;
public class HealthTopicContent : WebContent
{
    public override string TypeName { get; protected set; } = nameof(HealthTopicContent);
}

// TODO HealthTopicContent