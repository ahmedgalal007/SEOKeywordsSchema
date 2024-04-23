using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations;
public class RsvpResponseType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(RsvpResponseType);
}


// TODO Member RsvpResponseMaybe
// TODO Member RsvpResponseNo
// TODO Member RsvpResponseYes