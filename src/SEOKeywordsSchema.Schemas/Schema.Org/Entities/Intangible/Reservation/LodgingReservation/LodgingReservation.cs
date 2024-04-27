using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Reservation;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Reservation.LodgingReservation;
public class LodgingReservation : Reservation
{
    public override string TypeName { get; protected set; } = nameof(LodgingReservation);
}