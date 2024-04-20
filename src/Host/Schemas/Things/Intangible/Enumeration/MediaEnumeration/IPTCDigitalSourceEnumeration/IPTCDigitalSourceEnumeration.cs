using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.MediaEnumerations;
public class IPTCDigitalSourceEnumeration : MediaEnumeration
{
    public override string TypeName { get; protected set; } = nameof(IPTCDigitalSourceEnumeration);
}
