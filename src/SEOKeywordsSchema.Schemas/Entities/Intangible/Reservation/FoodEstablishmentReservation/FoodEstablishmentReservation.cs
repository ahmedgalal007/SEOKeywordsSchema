using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Reservations;
public class FoodEstablishmentReservation : Reservation
{
    public override string TypeName { get; protected set; } = nameof(FoodEstablishmentReservation);
}