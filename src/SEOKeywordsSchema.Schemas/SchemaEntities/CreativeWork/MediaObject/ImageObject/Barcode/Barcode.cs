﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.MediaObjects.ImageObjects;
public class Barcode: ImageObject 
{
    public override string TypeName { get; protected set; } = nameof(Barcode);
}