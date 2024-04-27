using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.SocialMediaPosting.BlogPosting;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.SocialMediaPosting.BlogPosting.LiveBlogPosting;
public class LiveBlogPosting : BlogPosting
{
    public override string TypeName { get; protected set; } = nameof(LiveBlogPosting);
}
