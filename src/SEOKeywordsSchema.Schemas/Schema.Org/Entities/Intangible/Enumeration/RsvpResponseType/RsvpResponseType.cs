using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.RsvpResponseType;
public class RsvpResponseType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(RsvpResponseType);
}


// TODO Member RsvpResponseMaybe
// TODO Member RsvpResponseNo
// TODO Member RsvpResponseYes