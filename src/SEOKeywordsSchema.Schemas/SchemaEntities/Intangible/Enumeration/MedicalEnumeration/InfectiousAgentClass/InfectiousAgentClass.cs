using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MedicalEnumerations;
public class InfectiousAgentClass : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(InfectiousAgentClass);
}


// TODO Member Bacteria
// TODO Member Fungus
// TODO Member MulticellularParasite
// TODO Member Prion
// TODO Member Protozoa
// TODO Member Virus