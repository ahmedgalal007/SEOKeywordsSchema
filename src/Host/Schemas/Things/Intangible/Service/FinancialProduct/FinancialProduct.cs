using FSH.WebApi.Domain.Schemas.Things.CreativeWorks;
using FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Services;
public class FinancialProduct : Service
{
    public override string TypeName { get; protected set; } = nameof(FinancialProduct);
}


// TODO BankAccount
// TODO CurrencyConversionService
// TODO InvestmentOrDeposit
// TODO LoanOrCredit
// TODO PaymentCard
// TODO PaymentService