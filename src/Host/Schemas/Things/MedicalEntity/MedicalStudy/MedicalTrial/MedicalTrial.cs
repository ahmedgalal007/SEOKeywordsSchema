﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.MedicalStudies;
public class MedicalObservationalStudy : MedicalStudy 
{
    public override string TypeName { get; protected set; } = nameof(MedicalObservationalStudy);
}