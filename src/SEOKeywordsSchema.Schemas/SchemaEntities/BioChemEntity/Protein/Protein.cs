﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.BioChemEntities;
public class Protein : BioChemEntity
{
    public override string TypeName { get; protected set; } = nameof(Protein);
}