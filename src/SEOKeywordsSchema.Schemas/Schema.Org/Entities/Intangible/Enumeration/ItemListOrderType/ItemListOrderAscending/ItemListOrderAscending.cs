﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ItemListOrderType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ItemListOrderType.ItemListOrderAscending;
public class ItemListOrderAscending : ItemListOrderType
{
    public override string TypeName { get; protected set; } = nameof(ItemListOrderAscending);
}
