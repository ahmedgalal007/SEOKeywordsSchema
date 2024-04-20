using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.StatusEnumerations;
public class ReservationStatusType : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(ReservationStatusType);
}


// TODO Member ReservationCancelled
// TODO Member ReservationConfirmed
// TODO Member ReservationHold
// TODO Member ReservationPending