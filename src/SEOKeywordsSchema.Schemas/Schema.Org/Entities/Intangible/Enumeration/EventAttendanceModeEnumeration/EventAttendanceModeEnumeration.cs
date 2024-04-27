using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.EventAttendanceModeEnumeration;
public class EventAttendanceModeEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(EventAttendanceModeEnumeration);
}


// TODO Member MixedEventAttendanceMode
// TODO Member OfflineEventAttendanceMode
// TODO Member OnlineEventAttendanceMode