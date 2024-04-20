using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles;
public class StructuredValue : Intangible
{
    public override string TypeName { get; protected set; } = nameof(StructuredValue);
}

// TODO CDCPMDRecord
// TODO ContactPoint
// TODO DefinedRegion
// TODO DeliveryTimeSettings
// TODO EngineSpecification
// TODO ExchangeRateSpecification
// TODO GeoCoordinates
// TODO GeoShape
// TODO InteractionCounter
// TODO MonetaryAmount
// TODO NutritionInformation
// TODO OfferShippingDetails
// TODO OpeningHoursSpecification
// TODO OwnershipInfo
// TODO PostalCodeRangeSpecification
// TODO PriceSpecification
// TODO PropertyValue
// TODO QuantitativeValue
// TODO QuantitativeValueDistribution
// TODO RepaymentSpecification
// TODO ShippingDeliveryTime
// TODO ShippingRateSettings
// TODO TypeAndQuantityNode
// TODO WarrantyPromise