using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.TechArticle;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.TechArticle.APIReference;
public class APIReference : TechArticle
{
    public override string TypeName { get; protected set; } = nameof(APIReference);
}
