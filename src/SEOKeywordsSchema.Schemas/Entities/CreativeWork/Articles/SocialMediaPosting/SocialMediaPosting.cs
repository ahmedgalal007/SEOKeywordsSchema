using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.Articles;
public class SocialMediaPosting : Article
{
    public override string TypeName { get; protected set; } = nameof(SocialMediaPosting);
}


// TODO BlogPosting
// TODO DiscussionForumPosting
