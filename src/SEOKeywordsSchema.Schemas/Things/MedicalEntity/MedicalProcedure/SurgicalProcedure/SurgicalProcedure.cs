﻿using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.MedicalProcedures;
public class SurgicalProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(SurgicalProcedure);
}