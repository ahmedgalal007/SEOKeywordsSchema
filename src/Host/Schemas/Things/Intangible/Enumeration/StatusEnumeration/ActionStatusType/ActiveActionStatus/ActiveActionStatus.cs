﻿using FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.StatusEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.StatusEnumerations.ActionStatusTypes;
public class ActiveActionStatus : ActionStatusType
{
    public override string TypeName { get; protected set; } = nameof(ActiveActionStatus);
}
