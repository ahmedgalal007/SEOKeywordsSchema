﻿using System;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.Articles.SocialMediaPostings;
public class DiscussionForumPosting : SocialMediaPosting 
{
    public override string TypeName { get; protected set; } = nameof(DiscussionForumPosting);
}