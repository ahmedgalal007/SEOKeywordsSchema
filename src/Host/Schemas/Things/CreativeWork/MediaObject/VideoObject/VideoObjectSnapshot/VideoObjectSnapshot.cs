using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.MediaObjects.VideoObjects;
public class VideoObjectSnapshot : VideoObject
{
    public override string TypeName { get; protected set; } = nameof(VideoObjectSnapshot);
}
