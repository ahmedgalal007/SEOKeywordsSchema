using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.WarrantyScope;
public class WarrantyScope : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(WarrantyScope);
}


// Common Values http://purl.org/goodrelations/v1#Labor-BringIn
// Common Values http://purl.org/goodrelations/v1#PartsAndLabor-BringIn
// Common Values http://purl.org/goodrelations/v1#PartsAndLabor-PickUp