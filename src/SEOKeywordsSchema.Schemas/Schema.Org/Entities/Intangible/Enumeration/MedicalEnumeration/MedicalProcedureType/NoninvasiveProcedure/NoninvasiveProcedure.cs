using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalProcedureType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalProcedureType.NoninvasiveProcedure;
public class NoninvasiveProcedure : MedicalProcedureType
{
    public override string TypeName { get; protected set; } = nameof(NoninvasiveProcedure);
}
