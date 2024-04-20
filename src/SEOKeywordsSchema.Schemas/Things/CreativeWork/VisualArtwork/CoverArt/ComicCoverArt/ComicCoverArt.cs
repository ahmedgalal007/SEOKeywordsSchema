using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.VisualArtworks.CoverArts;
public class ComicCoverArt : CoverArt
{
    public override string TypeName { get; protected set; } = nameof(ComicCoverArt);
}
