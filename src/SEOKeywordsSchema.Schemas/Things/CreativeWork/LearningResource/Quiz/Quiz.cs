﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.LearningResources;
public class Quiz : LearningResource
{
    public override string TypeName { get; protected set; } = nameof(Quiz);
}