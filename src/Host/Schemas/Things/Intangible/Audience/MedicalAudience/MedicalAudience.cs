﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Audiences;
public class MedicalAudience : Audience
{
    public override string TypeName { get; protected set; } = nameof(MedicalAudience);
}

