using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.AudioObject;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.AudioObject.AudioObjectSnapshot;
public class AudioObjectSnapshot : AudioObject
{
    public override string TypeName { get; protected set; } = nameof(AudioObjectSnapshot);
}
