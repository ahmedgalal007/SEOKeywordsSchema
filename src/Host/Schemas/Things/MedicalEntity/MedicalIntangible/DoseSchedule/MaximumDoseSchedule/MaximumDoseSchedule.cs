﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.MedicalIntangibles.DoseSchedules;
public class MaximumDoseSchedule : DoseSchedule
{
    public override string TypeName { get; protected set; } = nameof(MaximumDoseSchedule);
}
