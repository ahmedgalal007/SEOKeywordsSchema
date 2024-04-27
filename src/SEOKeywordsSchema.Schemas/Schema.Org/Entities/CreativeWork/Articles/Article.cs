using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles;
[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<Article>))]
public class Article : BaseSchemaEntity, ISchemaEntity
{
    public virtual string TypeName { get; protected set; } = typeof(CreativeWork).FullName + '.' + nameof(Article);
    public CreativeWork Parent { get; set; }
    // public override ISchemaEntity? Parent { get; set; }
    public new string SchemaType { get; set; }

    public bool IsLeafe()
    {
        return false;
    }
}


// TODO AdvertiserContentArticle
// TODO NewsArticle
// TODO Report
// TODO SatiricalArticle
// TODO ScholarlyArticle
// TODO SocialMediaPosting
// TODO TechArticle