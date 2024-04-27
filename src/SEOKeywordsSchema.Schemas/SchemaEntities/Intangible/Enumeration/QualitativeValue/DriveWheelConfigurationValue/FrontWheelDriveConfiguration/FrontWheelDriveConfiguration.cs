using SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.QualitativeValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.QualitativeValues.DriveWheelConfigurationValues;
public class FrontWheelDriveConfiguration : DriveWheelConfigurationValue
{
    public override string TypeName { get; protected set; } = nameof(FrontWheelDriveConfiguration);
}
