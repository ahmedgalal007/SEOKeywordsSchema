using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Articles.SocialMediaPostings.BlogPostings;
public class LiveBlogPosting : BlogPosting
{
    public override string TypeName { get; protected set; } = nameof(LiveBlogPosting);
}
