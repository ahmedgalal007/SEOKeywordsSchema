using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.VisualArtwork.CoverArt;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.VisualArtwork.CoverArt.ComicCoverArt;
public class ComicCoverArt : CoverArt
{
    public override string TypeName { get; protected set; } = nameof(ComicCoverArt);
}
