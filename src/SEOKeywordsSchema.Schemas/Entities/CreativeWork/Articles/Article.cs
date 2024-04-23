using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks;
[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<Article>))]
public class Article : BaseSchemaEntity, ISchemaEntity
{
    public virtual string TypeName { get; protected set; } = typeof(CreativeWork).FullName + '.' + nameof(Article);
    public CreativeWork Parent { get; set; }
    // public override ISchemaEntity? Parent { get; set; }
    public new String SchemaType { get; set; }

    public Boolean IsLeafe()
    {
        throw new NotImplementedException();
    }
}


// TODO AdvertiserContentArticle
// TODO NewsArticle
// TODO Report
// TODO SatiricalArticle
// TODO ScholarlyArticle
// TODO SocialMediaPosting
// TODO TechArticle