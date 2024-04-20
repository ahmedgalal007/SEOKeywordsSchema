using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.StatusEnumerations;
public class EventStatusType : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(EventStatusType);
}


// TODO Member EventCancelled
// TODO Member EventMovedOnline
// TODO Member EventPostponed
// TODO Member EventRescheduled
// TODO Member EventScheduled