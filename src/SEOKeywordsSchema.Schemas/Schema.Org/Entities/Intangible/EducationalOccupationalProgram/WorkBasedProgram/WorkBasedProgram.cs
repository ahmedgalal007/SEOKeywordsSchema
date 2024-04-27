using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.EducationalOccupationalProgram;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.EducationalOccupationalProgram.WorkBasedProgram;
public class WorkBasedProgram : EducationalOccupationalProgram
{
    public override string TypeName { get; protected set; } = nameof(WorkBasedProgram);
}
