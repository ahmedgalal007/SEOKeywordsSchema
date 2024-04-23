using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MerchantReturnEnumerations;
public class MerchantReturnFiniteReturnWindow : MerchantReturnEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MerchantReturnFiniteReturnWindow);
}
