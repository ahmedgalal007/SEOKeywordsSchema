using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.MusicVideoObject;
public class MusicVideoObject : MediaObject
{
    public override string TypeName { get; protected set; } = nameof(MusicVideoObject);
}
