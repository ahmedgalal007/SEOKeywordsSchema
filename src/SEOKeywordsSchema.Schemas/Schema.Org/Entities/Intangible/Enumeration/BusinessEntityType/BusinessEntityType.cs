using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.BusinessEntityType;
public class BusinessEntityType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(BusinessEntityType);
}


// Common Values http://purl.org/goodrelations/v1#Business
// Common Values http://purl.org/goodrelations/v1#Enduser
// Common Values http://purl.org/goodrelations/v1#PublicInstitution
// Common Values http://purl.org/goodrelations/v1#Reseller