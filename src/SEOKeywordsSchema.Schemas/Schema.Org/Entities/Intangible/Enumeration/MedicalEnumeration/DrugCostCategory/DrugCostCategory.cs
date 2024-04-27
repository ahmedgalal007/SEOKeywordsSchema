using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.DrugCostCategory;
public class DrugCostCategory : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(DrugCostCategory);
}


// TODO Member ReimbursementCap
// TODO Member Retail
// TODO Member Wholesale