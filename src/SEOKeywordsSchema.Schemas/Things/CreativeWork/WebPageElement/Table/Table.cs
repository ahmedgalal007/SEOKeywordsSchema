﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.WebPageElements;
public class Table : WebPageElement
{
    public override string TypeName { get; protected set; } = nameof(Table);
}