﻿using SEOKeywordsSchema.Schemas.Things.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles;
public class ItemList : Intangible
{
    public override string TypeName { get; protected set; } = nameof(ItemList);
}


// TODO BreadcrumbList
// TODO HowToSection
// TODO HowToStep
// TODO OfferCatalog