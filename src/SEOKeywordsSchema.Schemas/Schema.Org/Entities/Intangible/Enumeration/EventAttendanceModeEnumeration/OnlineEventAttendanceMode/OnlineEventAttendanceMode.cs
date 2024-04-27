using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.EventAttendanceModeEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.EventAttendanceModeEnumeration.OnlineEventAttendanceMode;
public class OnlineEventAttendanceMode : EventAttendanceModeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(OnlineEventAttendanceMode);
}
