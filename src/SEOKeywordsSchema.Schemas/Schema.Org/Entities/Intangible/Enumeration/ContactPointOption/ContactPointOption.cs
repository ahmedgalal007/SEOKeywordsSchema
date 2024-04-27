using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ContactPointOption;
public class ContactPointOption : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(ContactPointOption);
}


// TODO HearingImpairedSupported
// TODO TollFree