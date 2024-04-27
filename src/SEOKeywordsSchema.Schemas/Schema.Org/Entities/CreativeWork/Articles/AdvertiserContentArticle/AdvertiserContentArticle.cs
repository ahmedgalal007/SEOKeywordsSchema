using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.AdvertiserContentArticle;
public class AdvertiserContentArticle : Article
{
    public override string TypeName { get; protected set; } = nameof(AdvertiserContentArticle);
}
