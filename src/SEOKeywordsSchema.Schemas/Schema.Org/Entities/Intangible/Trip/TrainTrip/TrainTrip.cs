using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Trip;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Trip.TrainTrip;
public class TrainTrip : Trip
{
    public override string TypeName { get; protected set; } = nameof(TrainTrip);
}
