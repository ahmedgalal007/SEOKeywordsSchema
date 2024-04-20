using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks;
public class MediaObject : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(MediaObject);
}


// TODO 3DModel
// TODO AmpStory
// TODO AudioObject
// TODO DataDownload
// TODO ImageObject
// TODO LegislationObject
// TODO MusicVideoObject
// TODO TextObject
// TODO VideoObject