﻿using SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations.InfectiousAgentClasses;
public class Virus : InfectiousAgentClass
{
    public override string TypeName { get; protected set; } = nameof(Virus);
}