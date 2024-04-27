﻿using SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MedicalEnumerations.DrugPrescriptionStatuses;
public class PrescriptionOnly : DrugPrescriptionStatus
{
    public override string TypeName { get; protected set; } = nameof(PrescriptionOnly);
}