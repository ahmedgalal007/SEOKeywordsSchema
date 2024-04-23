using System;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.Articles.SocialMediaPostings.BlogPostings;
public class LiveBlogPosting : BlogPosting
{
    public override string TypeName { get; protected set; } = nameof(LiveBlogPosting);
}
