﻿using SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations.MedicineSystemes;
public class Chiropractic : MedicineSystem
{
    public override string TypeName { get; protected set; } = nameof(Chiropractic);
}