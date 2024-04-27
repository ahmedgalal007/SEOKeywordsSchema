using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.DrugCostCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.DrugCostCategory.ReimbursementCap;
public class ReimbursementCap : DrugCostCategory
{
    public override string TypeName { get; protected set; } = nameof(ReimbursementCap);
}
