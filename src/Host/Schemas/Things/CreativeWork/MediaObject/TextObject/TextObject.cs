﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.MediaObjects;
public class TextObject : MediaObject
{
    public override string TypeName { get; protected set; } = nameof(TextObject);
}
