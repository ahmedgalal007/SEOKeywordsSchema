﻿using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.DoseSchedule;
public class DoseSchedule : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DoseSchedule);
}
