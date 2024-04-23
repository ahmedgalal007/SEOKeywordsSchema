using SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.QualitativeValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.QualitativeValues.DriveWheelConfigurationValues;
public class FourWheelDriveConfiguration : DriveWheelConfigurationValue
{
    public override string TypeName { get; protected set; } = nameof(FourWheelDriveConfiguration);
}
