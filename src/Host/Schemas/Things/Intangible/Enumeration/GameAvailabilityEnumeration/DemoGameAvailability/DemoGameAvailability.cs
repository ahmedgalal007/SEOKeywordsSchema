using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.GameAvailabilityEnumerations;
public class DemoGameAvailability : GameAvailabilityEnumeration
{
    public override string TypeName { get; protected set; } = nameof(DemoGameAvailability);
}
