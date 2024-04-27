using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.ImageObject;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.ImageObject.Barcode;
public class Barcode : ImageObject
{
    public override string TypeName { get; protected set; } = nameof(Barcode);
}
