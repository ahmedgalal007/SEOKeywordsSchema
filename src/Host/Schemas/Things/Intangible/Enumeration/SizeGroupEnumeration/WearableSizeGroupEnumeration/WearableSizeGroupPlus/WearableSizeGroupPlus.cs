﻿using FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.SizeGroupEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.SizeGroupEnumerations.WearableSizeGroupEnumerations;
public class WearableSizeGroupPlus : WearableSizeGroupEnumeration
{
    public override string TypeName { get; protected set; } = nameof(WearableSizeGroupPlus);
}
