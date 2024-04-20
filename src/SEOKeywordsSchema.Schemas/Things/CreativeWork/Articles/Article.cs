using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks;
public abstract class Article : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(Article);

}


// TODO AdvertiserContentArticle
// TODO NewsArticle
// TODO Report
// TODO SatiricalArticle
// TODO ScholarlyArticle
// TODO SocialMediaPosting
// TODO TechArticle