﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.AnatomicalStructures;
public class Muscle : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Muscle);
}
