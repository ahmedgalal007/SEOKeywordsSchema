using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.DeliveryMethod;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.DeliveryMethod.ParcelService;
public class ParcelService : DeliveryMethod
{
    public override string TypeName { get; protected set; } = nameof(ParcelService);
}

// Common Values http://purl.org/goodrelations/v1#DeliveryModeDirectDownload
// Common Values http://purl.org/goodrelations/v1#DeliveryModeFreight
// Common Values http://purl.org/goodrelations/v1#DeliveryModeMail
// Common Values http://purl.org/goodrelations/v1#DeliveryModeOwnFleet
// Common Values http://purl.org/goodrelations/v1#DeliveryModePickUp
// Common Values http://purl.org/goodrelations/v1#DHL
// Common Values http://purl.org/goodrelations/v1#FederalExpress
// Common Values http://purl.org/goodrelations/v1#UPS