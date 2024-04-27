using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration;
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