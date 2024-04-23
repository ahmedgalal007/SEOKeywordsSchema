using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.DigitalDocuments;
public class PresentationDigitalDocument :  DigitalDocument
{
    public override string TypeName { get; protected set; } = nameof(PresentationDigitalDocument);
}
