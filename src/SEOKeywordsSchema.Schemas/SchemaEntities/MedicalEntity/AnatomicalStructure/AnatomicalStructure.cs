﻿using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class AnatomicalStructure : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(AnatomicalStructure);
}