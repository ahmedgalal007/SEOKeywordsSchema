﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.HowToSection;
public class HowToSection : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(HowToSection);
}
