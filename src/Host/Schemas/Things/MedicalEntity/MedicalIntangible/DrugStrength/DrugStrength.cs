﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.MedicalIntangibles;
public class DrugStrength : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DrugStrength);
}
