using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Events.PublicationEvents;
public class BroadcastEvent: PublicationEvent
{
    public override string TypeName { get; protected set; } = nameof(BroadcastEvent);
}
