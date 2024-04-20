using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Trips;
public class TouristTrip : Trip
{
    public override string TypeName { get; protected set; } = nameof(TouristTrip);
}
