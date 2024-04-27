using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.Specialty;
public class Specialty : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(Specialty);
}


// TODO  MedicalSpecialty