﻿using SEOKeywordsSchema.Schemas.Things.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.ListItems;
public class HowToSection : ListItem
{
    public override string TypeName { get; protected set; } = nameof(HowToSection);
}