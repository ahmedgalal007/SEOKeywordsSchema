﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.DefinedTermSets;
public class CategoryCodeSet : DefinedTermSet
{
    public override string TypeName { get; protected set; } = nameof(CategoryCodeSet);
}
