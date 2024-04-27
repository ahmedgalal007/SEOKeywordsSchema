using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicAlbumReleaseType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MusicAlbumReleaseType.BroadcastRelease;
public class BroadcastRelease : MusicAlbumReleaseType
{
    public override string TypeName { get; protected set; } = nameof(BroadcastRelease);
}
