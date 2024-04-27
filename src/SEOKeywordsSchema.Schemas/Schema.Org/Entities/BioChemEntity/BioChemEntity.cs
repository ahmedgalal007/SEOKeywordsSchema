using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.BioChemEntity;
public abstract class BioChemEntity : Thing
{
    public override string TypeName { get; protected set; } = nameof(BioChemEntity);
}

// TODO ChemicalSubstance
// TODO Gene
// TODO MolecularEntity
// TODO Protein