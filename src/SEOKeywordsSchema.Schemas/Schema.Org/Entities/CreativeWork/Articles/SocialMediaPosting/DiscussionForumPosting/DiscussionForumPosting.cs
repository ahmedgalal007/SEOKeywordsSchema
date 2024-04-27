using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.SocialMediaPosting;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.SocialMediaPosting.DiscussionForumPosting;
public class DiscussionForumPosting : SocialMediaPosting
{
    public override string TypeName { get; protected set; } = nameof(DiscussionForumPosting);
}
