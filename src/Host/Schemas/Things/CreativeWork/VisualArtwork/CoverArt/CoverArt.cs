﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.VisualArtworks;
public class CoverArt: VisualArtwork
{
    public override string TypeName { get; protected set; } = nameof(CoverArt);
}
