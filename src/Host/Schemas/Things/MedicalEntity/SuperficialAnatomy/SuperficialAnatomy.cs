﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities;
public class SuperficialAnatomy : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(SuperficialAnatomy);
}
