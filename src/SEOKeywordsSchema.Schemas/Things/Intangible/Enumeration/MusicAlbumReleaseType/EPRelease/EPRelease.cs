using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.MusicAlbumReleaseTypes;
public class EPRelease : MusicAlbumReleaseType
{
    public override string TypeName { get; protected set; } = nameof(EPRelease);
}
