﻿using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.MedicalGuidelines;
public class MedicalGuidelineRecommendation : MedicalGuideline
{
    public override string TypeName { get; protected set; } = nameof(MedicalGuidelineRecommendation);
}