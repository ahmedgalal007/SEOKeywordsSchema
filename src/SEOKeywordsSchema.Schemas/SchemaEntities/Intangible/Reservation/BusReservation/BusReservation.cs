﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Reservations;
public class BusReservation : Reservation
{
    public override string TypeName { get; protected set; } = nameof(BusReservation);
}