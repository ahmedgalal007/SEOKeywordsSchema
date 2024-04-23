using SEOKeywordsSchema.Schemas.Entities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Services.FinancialProducts;
public class CurrencyConversionService : FinancialProduct
{
    public override string TypeName { get; protected set; } = nameof(CurrencyConversionService);
}
