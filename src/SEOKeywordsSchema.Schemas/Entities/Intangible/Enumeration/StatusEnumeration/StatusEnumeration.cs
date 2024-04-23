using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations;
public class StatusEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(StatusEnumeration);
}



// TODO ActionStatusType
// TODO EventStatusType
// TODO GameServerStatus
// TODO LegalForceStatus
// TODO OrderStatus
// TODO PaymentStatusType
// TODO ReservationStatusType