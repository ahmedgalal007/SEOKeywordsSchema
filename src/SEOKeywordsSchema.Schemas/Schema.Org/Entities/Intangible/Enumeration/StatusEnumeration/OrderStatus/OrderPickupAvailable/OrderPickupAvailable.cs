﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.OrderStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.OrderStatus.OrderPickupAvailable;
public class OrderPickupAvailable : OrderStatus
{
    public override string TypeName { get; protected set; } = nameof(OrderPickupAvailable);
}
