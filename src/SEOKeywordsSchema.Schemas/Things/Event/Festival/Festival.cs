﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Events;
public class Festival : Event
{
    public override string TypeName { get; protected set; } = nameof(Festival);
}