using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Trip;
public class Trip : Intangible
{
    public override string TypeName { get; protected set; } = nameof(Trip);
}


// TODO BoatTrip
// TODO BusTrip
// TODO Flight
// TODO TouristTrip
// TODO TrainTrip