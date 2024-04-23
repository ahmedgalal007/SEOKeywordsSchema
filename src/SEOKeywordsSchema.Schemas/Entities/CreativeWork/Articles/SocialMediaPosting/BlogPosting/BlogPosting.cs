using System;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.Articles.SocialMediaPostings;
public class BlogPosting : SocialMediaPosting
{
    public override string TypeName { get; protected set; } = nameof(BlogPosting);
}
