﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.Specialties.MedicalSpecialties;
public class Pediatric : MedicalSpecialty
{
    public override string TypeName { get; protected set; } = nameof(Pediatric);
}