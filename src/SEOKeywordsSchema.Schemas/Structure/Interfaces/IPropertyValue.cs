﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Structure.Interfaces;
internal interface IPropertyValue
{
    public IType[] Values { get; set; }
}
