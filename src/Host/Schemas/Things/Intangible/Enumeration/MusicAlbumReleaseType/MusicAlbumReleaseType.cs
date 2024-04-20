using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations;
public class MusicAlbumReleaseType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(MusicAlbumReleaseType);
}


// TODO Member AlbumRelease
// TODO Member BroadcastRelease
// TODO Member EPRelease
// TODO Member SingleRelease