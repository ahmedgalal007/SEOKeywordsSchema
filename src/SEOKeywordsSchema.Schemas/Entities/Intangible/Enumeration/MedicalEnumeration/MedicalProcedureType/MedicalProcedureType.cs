using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MedicalEnumerations;
public class MedicalProcedureType : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalProcedureType);
}


// TODO Member NoninvasiveProcedure
// TODO Member PercutaneousProcedure