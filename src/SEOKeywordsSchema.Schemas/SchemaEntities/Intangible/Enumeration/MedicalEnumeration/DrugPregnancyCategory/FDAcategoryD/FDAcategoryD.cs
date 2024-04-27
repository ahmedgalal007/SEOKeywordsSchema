using SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MedicalEnumerations.DrugPregnancyCategories;
public class FDAcategoryD : DrugPregnancyCategory
{
    public override string TypeName { get; protected set; } = nameof(FDAcategoryD);
}
