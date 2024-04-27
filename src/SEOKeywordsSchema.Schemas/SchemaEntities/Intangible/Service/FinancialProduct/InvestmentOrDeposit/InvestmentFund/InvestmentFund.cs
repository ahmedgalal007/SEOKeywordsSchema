using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Services.FinancialProducts.BankAccounts.InvestmentOrDeposits;
public class InvestmentFund : InvestmentOrDeposit
{
    public override string TypeName { get; protected set; } = nameof(InvestmentFund);
}
