using System;

namespace SEOKeywordsSchema.Schemas.Entities.BioChemEntities;
public abstract class BioChemEntity : Thing
{
    public override string TypeName { get; protected set; } = nameof(BioChemEntity);
}

// TODO ChemicalSubstance
// TODO Gene
// TODO MolecularEntity
// TODO Protein