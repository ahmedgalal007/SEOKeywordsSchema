using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.BioChemEntities;
public abstract class BioChemEntity : Thing
{
    public override string TypeName { get; protected set; } = nameof(BioChemEntity);
}

// TODO ChemicalSubstance
// TODO Gene
// TODO MolecularEntity
// TODO Protein