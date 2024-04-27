using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MediaEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MediaEnumeration.IPTCDigitalSourceEnumeration;
public class IPTCDigitalSourceEnumeration : MediaEnumeration
{
    public override string TypeName { get; protected set; } = nameof(IPTCDigitalSourceEnumeration);
}
