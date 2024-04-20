using System;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Articles.SocialMediaPostings.BlogPostings;
public class LiveBlogPosting : BlogPosting
{
    public override string TypeName { get; protected set; } = nameof(LiveBlogPosting);
}
