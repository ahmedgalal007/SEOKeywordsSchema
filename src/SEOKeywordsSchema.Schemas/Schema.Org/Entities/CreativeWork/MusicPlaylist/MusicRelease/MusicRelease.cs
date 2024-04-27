using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MusicPlaylist;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MusicPlaylist.MusicRelease;
public class MusicRelease : MusicPlaylist
{
    public override string TypeName { get; protected set; } = nameof(MusicRelease);
}
