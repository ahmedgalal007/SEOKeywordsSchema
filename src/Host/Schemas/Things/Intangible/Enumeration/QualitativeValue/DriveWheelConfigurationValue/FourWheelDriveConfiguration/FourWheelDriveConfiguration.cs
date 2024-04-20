using FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.QualitativeValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.QualitativeValues.DriveWheelConfigurationValues;
public class FourWheelDriveConfiguration : DriveWheelConfigurationValue
{
    public override string TypeName { get; protected set; } = nameof(FourWheelDriveConfiguration);
}
