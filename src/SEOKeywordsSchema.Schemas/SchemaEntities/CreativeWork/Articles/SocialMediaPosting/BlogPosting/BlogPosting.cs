using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Articles.SocialMediaPostings;
public class BlogPosting : SocialMediaPosting
{
    public override string TypeName { get; protected set; } = nameof(BlogPosting);
}
