﻿using SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MedicalEnumerations.MedicalTrialDesignes;
public class OpenTrial : MedicalTrialDesign
{
    public override string TypeName { get; protected set; } = nameof(OpenTrial);
}