using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicAlbumProductionType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicAlbumProductionType.SpokenWordAlbum;
public class SpokenWordAlbum : MusicAlbumProductionType
{
    public override string TypeName { get; protected set; } = nameof(SpokenWordAlbum);
}
