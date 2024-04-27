using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Service.FinancialProduct.InvestmentOrDeposit;
using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Service.FinancialProduct.InvestmentOrDeposit.InvestmentFund;
public class InvestmentFund : InvestmentOrDeposit
{
    public override string TypeName { get; protected set; } = nameof(InvestmentFund);
}
