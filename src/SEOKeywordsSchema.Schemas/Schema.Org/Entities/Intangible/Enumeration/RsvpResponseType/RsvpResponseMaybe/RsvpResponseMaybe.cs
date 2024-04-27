using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.RsvpResponseType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.RsvpResponseType.RsvpResponseMaybe;
public class RsvpResponseMaybe : RsvpResponseType
{
    public override string TypeName { get; protected set; } = nameof(RsvpResponseMaybe);
}
