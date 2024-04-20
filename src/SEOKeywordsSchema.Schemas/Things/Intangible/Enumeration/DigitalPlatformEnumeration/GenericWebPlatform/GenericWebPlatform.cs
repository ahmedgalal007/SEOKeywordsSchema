using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.DigitalPlatformEnumerations;
public class GenericWebPlatform : DigitalPlatformEnumeration
{
    public override string TypeName { get; protected set; } = nameof(GenericWebPlatform);
}
