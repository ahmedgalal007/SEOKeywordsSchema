﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.SoftwareApplication;
public class SoftwareApplication : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(SoftwareApplication);
}


// TODO MobileApplication
// TODO VideoGame
// TODO WebApplication
