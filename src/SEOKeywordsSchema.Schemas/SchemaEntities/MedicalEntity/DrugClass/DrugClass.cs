﻿using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class DrugClass : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(DrugClass);
}