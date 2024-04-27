using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
public class MusicPlaylist : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(MusicPlaylist);
}


// TODO MusicAlbum
// TODO MusicRelease