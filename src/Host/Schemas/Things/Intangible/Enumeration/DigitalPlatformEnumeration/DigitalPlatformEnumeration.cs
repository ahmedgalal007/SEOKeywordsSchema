using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations;
public class DigitalPlatformEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(DigitalPlatformEnumeration);
}


// TODO Enumerations AndroidPlatform
// TODO Enumerations DesktopWebPlatform
// TODO Enumerations GenericWebPlatform
// TODO Enumerations IOSPlatform
// TODO Enumerations MobileWebPlatform