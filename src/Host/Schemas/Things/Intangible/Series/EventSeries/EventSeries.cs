using FSH.WebApi.Domain.Schemas.Things.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Serieses;
public class EventSeries : Series
{
    public override string TypeName { get; protected set; } = nameof(EventSeries);
}
