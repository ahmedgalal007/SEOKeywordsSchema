﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.SoftwareApplications;
public class VideoGame : SoftwareApplication
{
    public override string TypeName { get; protected set; } = nameof(VideoGame);
}
