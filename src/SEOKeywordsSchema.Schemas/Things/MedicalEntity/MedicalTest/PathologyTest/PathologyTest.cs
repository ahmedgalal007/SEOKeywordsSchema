﻿using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class PathologyTest : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(PathologyTest);
}