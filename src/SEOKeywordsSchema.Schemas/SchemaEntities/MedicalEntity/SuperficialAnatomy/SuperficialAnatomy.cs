﻿using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class SuperficialAnatomy : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(SuperficialAnatomy);
}