using System;
using SEOKeywordsSchema.Schemas.Entities.CreativeWorks;

namespace Host.Schemas.Things.CreativeWork.Articles;
public class AdvertiserContentArticle : Article
{
    public override string TypeName { get; protected set; } = nameof(AdvertiserContentArticle);
}
