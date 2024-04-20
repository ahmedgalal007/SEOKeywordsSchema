using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles;
public class Enumeration : Intangible
{
    public override string TypeName { get; protected set; } = nameof(Enumeration);
}


// TODO AdultOrientedEnumeration
// TODO BoardingPolicyType
// TODO BookFormatType
// TODO BusinessEntityType
// TODO BusinessFunction
// TODO CarUsageType
// TODO ContactPointOption
// TODO DayOfWeek
// TODO DeliveryMethod
// TODO DigitalDocumentPermissionType
// TODO DigitalPlatformEnumeration
// TODO EnergyEfficiencyEnumeration
// TODO EventAttendanceModeEnumeration
// TODO GameAvailabilityEnumeration
// TODO GamePlayMode
// TODO GenderType
// TODO GovernmentBenefitsType
// TODO HealthAspectEnumeration
// TODO ItemAvailability
// TODO ItemListOrderType
// TODO LegalValueLevel
// TODO MapCategoryType
// TODO MeasurementMethodEnum
// TODO MeasurementTypeEnumeration
// TODO MediaEnumeration
// TODO MediaManipulationRatingEnumeration
// TODO MedicalEnumeration
// TODO MerchantReturnEnumeration
// TODO MusicAlbumProductionType
// TODO MusicAlbumReleaseType
// TODO MusicReleaseFormatType
// TODO NonprofitType
// TODO OfferItemCondition
// TODO PaymentMethod
// TODO PhysicalActivityCategory
// TODO PriceComponentTypeEnumeration
// TODO PriceTypeEnumeration
// TODO QualitativeValue
// TODO RefundTypeEnumeration
// TODO RestrictedDiet
// TODO ReturnFeesEnumeration
// TODO ReturnLabelSourceEnumeration
// TODO ReturnMethodEnumeration
// TODO RsvpResponseType
// TODO SizeGroupEnumeration
// TODO SizeSystemEnumeration
// TODO Specialty
// TODO StatusEnumeration
// TODO WarrantyScope