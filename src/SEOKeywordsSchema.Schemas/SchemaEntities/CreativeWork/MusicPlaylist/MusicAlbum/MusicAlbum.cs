﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.MusicPlaylists;
public class MusicAlbum : MusicPlaylist
{
    public override string TypeName { get; protected set; } = nameof(MusicAlbum);
}