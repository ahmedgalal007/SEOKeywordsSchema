﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities;
public class DrugCost : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(DrugCost);
}
