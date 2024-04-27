using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations;
public class WarrantyScope : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(WarrantyScope);
}


// Common Values http://purl.org/goodrelations/v1#Labor-BringIn
// Common Values http://purl.org/goodrelations/v1#PartsAndLabor-BringIn
// Common Values http://purl.org/goodrelations/v1#PartsAndLabor-PickUp