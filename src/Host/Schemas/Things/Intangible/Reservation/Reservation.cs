﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles;
public class Reservation : Intangible
{
    public override string TypeName { get; protected set; } = nameof(Reservation);
}


// TODO BoatReservation
// TODO BusReservation
// TODO EventReservation
// TODO FlightReservation
// TODO FoodEstablishmentReservation
// TODO LodgingReservation
// TODO RentalCarReservation
// TODO ReservationPackage
// TODO TaxiReservation
// TODO TrainReservation