﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.Specialties.MedicalSpecialties;
public class Toxicologic : MedicalSpecialty
{
    public override string TypeName { get; protected set; } = nameof(Toxicologic);
}