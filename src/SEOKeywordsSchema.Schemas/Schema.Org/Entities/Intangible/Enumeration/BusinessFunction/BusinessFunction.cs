using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.BusinessFunction;
public class BusinessFunction : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(BusinessFunction);
}


// Common Values http://purl.org/goodrelations/v1#ConstructionInstallation
// Common Values http://purl.org/goodrelations/v1#Dispose
// Common Values http://purl.org/goodrelations/v1#LeaseOut
// Common Values http://purl.org/goodrelations/v1#Maintain
// Common Values http://purl.org/goodrelations/v1#ProvideService
// Common Values http://purl.org/goodrelations/v1#Repair
// Common Values http://purl.org/goodrelations/v1#Sell
// Common Values http://purl.org/goodrelations/v1#Buy