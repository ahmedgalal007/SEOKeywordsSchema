using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicAlbumReleaseType;
public class MusicAlbumReleaseType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(MusicAlbumReleaseType);
}


// TODO Member AlbumRelease
// TODO Member BroadcastRelease
// TODO Member EPRelease
// TODO Member SingleRelease