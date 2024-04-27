using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MusicPlaylist;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MusicPlaylist.MusicAlbum;
public class MusicAlbum : MusicPlaylist
{
    public override string TypeName { get; protected set; } = nameof(MusicAlbum);
}
