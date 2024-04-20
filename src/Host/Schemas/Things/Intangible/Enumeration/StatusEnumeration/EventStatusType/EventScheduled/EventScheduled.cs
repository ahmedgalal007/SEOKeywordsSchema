using FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.StatusEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.StatusEnumerations.EventStatusTypes;
public class EventScheduled : EventStatusType
{
    public override string TypeName { get; protected set; } = nameof(EventScheduled);
}
