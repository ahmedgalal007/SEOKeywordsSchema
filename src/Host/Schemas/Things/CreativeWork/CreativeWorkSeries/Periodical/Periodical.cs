﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.CreativeWorkSerieses;
public class Periodical : CreativeWorkSeries
{
    public override string TypeName { get; protected set; } = nameof(Periodical);
}
