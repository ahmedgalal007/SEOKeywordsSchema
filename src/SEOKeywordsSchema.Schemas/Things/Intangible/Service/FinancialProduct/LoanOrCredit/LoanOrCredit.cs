using SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.PaymentMethods.PaymentCards;

using SEOKeywordsSchema.Schemas.Things.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Services.FinancialProducts;
public class LoanOrCredit : FinancialProduct
{
    public override string TypeName { get; protected set; } = nameof(LoanOrCredit);
}


// TODO CreditCard
// TODO MortgageLoan