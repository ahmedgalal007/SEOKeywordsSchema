using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.EventAttendanceModeEnumerations;
public class OnlineEventAttendanceMode : EventAttendanceModeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(OnlineEventAttendanceMode);
}
