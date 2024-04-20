using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.ComicStories;
public class ComicCoverArt : ComicStory
{
    public override string TypeName { get; protected set; } = nameof(ComicCoverArt);
}
