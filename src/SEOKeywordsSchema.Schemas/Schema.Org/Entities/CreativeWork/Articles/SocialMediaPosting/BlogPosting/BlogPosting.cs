using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.SocialMediaPosting;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.SocialMediaPosting.BlogPosting;
public class BlogPosting : SocialMediaPosting
{
    public override string TypeName { get; protected set; } = nameof(BlogPosting);
}
