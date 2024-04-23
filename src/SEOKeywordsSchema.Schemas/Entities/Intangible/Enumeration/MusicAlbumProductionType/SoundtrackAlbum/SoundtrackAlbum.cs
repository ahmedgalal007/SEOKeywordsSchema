using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MusicAlbumProductionTypes;
public class SoundtrackAlbum : MusicAlbumProductionType
{
    public override string TypeName { get; protected set; } = nameof(SoundtrackAlbum);
}
