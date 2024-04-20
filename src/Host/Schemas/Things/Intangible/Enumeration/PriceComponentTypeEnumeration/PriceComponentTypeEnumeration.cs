﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations;
public class PriceComponentTypeEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(PriceComponentTypeEnumeration);
}


// TODO ActivationFee
// TODO CleaningFee
// TODO DistanceFee
// TODO Downpayment
// TODO Installment
// TODO Subscription