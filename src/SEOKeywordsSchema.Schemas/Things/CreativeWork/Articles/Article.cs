using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks;
[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<Article>))]
public class Article : BaseEntity
{
    public virtual string TypeName { get; protected set; } = typeof(CreativeWork).FullName + '.' + nameof(Article);
    public virtual CreativeWork Parent { get; set; }

}


// TODO AdvertiserContentArticle
// TODO NewsArticle
// TODO Report
// TODO SatiricalArticle
// TODO ScholarlyArticle
// TODO SocialMediaPosting
// TODO TechArticle