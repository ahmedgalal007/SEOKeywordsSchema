﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.HealthAspectEnumerations;
public class SelfCareHealthAspect : HealthAspectEnumeration
{
    public override string TypeName { get; protected set; } = nameof(SelfCareHealthAspect);
}
