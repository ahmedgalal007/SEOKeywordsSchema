using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations;
public class DeliveryMethod : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(DeliveryMethod);
}

// TODO LockerDelivery
// TODO OnSitePickup
// TODO ParcelService

// Common Values http://purl.org/goodrelations/v1#DeliveryModeDirectDownload
// Common Values http://purl.org/goodrelations/v1#DeliveryModeFreight
// Common Values http://purl.org/goodrelations/v1#DeliveryModeMail
// Common Values http://purl.org/goodrelations/v1#DeliveryModeOwnFleet
// Common Values http://purl.org/goodrelations/v1#DeliveryModePickUp
// Common Values http://purl.org/goodrelations/v1#DHL
// Common Values http://purl.org/goodrelations/v1#FederalExpress
// Common Values http://purl.org/goodrelations/v1#UPS