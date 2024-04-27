using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.DigitalPlatformEnumeration;
public class DigitalPlatformEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(DigitalPlatformEnumeration);
}


// TODO Enumerations AndroidPlatform
// TODO Enumerations DesktopWebPlatform
// TODO Enumerations GenericWebPlatform
// TODO Enumerations IOSPlatform
// TODO Enumerations MobileWebPlatform