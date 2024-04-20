using System;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Articles.SocialMediaPostings;
public class BlogPosting : SocialMediaPosting
{
    public override string TypeName { get; protected set; } = nameof(BlogPosting);
}
