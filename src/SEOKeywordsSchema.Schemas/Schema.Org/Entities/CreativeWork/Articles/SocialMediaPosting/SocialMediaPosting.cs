using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.SocialMediaPosting;
public class SocialMediaPosting : Article
{
    public override string TypeName { get; protected set; } = nameof(SocialMediaPosting);
}


// TODO BlogPosting
// TODO DiscussionForumPosting
