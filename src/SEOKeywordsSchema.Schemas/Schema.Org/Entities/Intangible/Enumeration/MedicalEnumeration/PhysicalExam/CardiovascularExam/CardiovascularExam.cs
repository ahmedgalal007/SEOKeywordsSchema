using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.PhysicalExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.PhysicalExam.CardiovascularExam;
public class CardiovascularExam : PhysicalExam
{
    public override string TypeName { get; protected set; } = nameof(CardiovascularExam);
}
