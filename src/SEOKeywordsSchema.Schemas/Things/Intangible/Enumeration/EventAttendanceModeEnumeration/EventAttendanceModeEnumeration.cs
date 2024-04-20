using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations;
public class EventAttendanceModeEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(EventAttendanceModeEnumeration);
}


// TODO Member MixedEventAttendanceMode
// TODO Member OfflineEventAttendanceMode
// TODO Member OnlineEventAttendanceMode