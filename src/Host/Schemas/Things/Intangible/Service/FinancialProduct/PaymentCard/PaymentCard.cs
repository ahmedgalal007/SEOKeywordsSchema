﻿using FSH.WebApi.Domain.Schemas.Things.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Services.FinancialProducts;
public class PaymentCard : FinancialProduct
{
    public override string TypeName { get; protected set; } = nameof(PaymentCard);
}