﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.BioChemEntity;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.BioChemEntity.Gene;
public class Gene : BioChemEntity
{
    public override string TypeName { get; protected set; } = nameof(Gene);
}
