﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.DeliveryMethods;
public class OnSitePickup : DeliveryMethod
{
    public override string TypeName { get; protected set; } = nameof(OnSitePickup);
}

// Common Values http://purl.org/goodrelations/v1#DeliveryModeDirectDownload
// Common Values http://purl.org/goodrelations/v1#DeliveryModeFreight
// Common Values http://purl.org/goodrelations/v1#DeliveryModeMail
// Common Values http://purl.org/goodrelations/v1#DeliveryModeOwnFleet
// Common Values http://purl.org/goodrelations/v1#DeliveryModePickUp
// Common Values http://purl.org/goodrelations/v1#DHL
// Common Values http://purl.org/goodrelations/v1#FederalExpress
// Common Values http://purl.org/goodrelations/v1#UPS