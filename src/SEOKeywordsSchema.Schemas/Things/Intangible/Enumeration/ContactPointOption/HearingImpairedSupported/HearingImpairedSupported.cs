using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations;

namespace Host.Schemas.Things.Intangible.Enumeration.ContactPointOptions;
public class HearingImpairedSupported : ContactPointOption
{
    public override string TypeName { get; protected set; } = nameof(HearingImpairedSupported);
}
