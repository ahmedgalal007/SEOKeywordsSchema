using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalProcedureType;
public class MedicalProcedureType : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalProcedureType);
}


// TODO Member NoninvasiveProcedure
// TODO Member PercutaneousProcedure