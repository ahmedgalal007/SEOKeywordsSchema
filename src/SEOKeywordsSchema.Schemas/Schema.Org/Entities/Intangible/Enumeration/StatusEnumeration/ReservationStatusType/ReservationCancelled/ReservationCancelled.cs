using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.ReservationStatusType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.ReservationStatusType.ReservationCancelled;
public class ReservationCancelled : ReservationStatusType
{
    public override string TypeName { get; protected set; } = nameof(ReservationCancelled);
}
