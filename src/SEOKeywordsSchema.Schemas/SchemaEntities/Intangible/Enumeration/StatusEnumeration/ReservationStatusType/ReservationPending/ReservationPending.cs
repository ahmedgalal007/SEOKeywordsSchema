﻿using SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.StatusEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.StatusEnumerations;
public class ReservationPending : ReservationStatusType
{
    public override string TypeName { get; protected set; } = nameof(ReservationPending);
}