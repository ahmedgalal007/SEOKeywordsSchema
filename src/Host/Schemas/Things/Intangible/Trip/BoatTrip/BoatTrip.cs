using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Trips;
public class BoatTrip : Trip
{
    public override string TypeName { get; protected set; } = nameof(BoatTrip);
}
