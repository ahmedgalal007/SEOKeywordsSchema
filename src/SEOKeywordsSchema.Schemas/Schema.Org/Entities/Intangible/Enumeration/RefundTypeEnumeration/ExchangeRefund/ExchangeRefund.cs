﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.RefundTypeEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.RefundTypeEnumeration.ExchangeRefund;
public class ExchangeRefund : RefundTypeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(ExchangeRefund);
}
