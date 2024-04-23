using System;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.Articles.SocialMediaPostings;
public class DiscussionForumPosting : SocialMediaPosting 
{
    public override string TypeName { get; protected set; } = nameof(DiscussionForumPosting);
}
