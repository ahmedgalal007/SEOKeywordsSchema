﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.EducationalOccupationalPrograms;
public class WorkBasedProgram : EducationalOccupationalProgram
{
    public override string TypeName { get; protected set; } = nameof(WorkBasedProgram);
}