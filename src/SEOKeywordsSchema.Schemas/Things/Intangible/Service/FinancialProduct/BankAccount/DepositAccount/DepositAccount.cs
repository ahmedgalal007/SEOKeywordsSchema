using SEOKeywordsSchema.Schemas.Things.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Services.FinancialProducts.BankAccounts;
public class DepositAccount : BankAccount
{
    public override string TypeName { get; protected set; } = nameof(DepositAccount);
}
