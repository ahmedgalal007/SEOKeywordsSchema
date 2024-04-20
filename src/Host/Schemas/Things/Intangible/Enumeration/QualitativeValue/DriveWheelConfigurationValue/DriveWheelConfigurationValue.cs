using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.QualitativeValues;
public class DriveWheelConfigurationValue : QualitativeValue
{
    public override string TypeName { get; protected set; } = nameof(DriveWheelConfigurationValue);
}


// TODO Member AllWheelDriveConfiguration
// TODO Member FourWheelDriveConfiguration
// TODO Member FrontWheelDriveConfiguration
// TODO Member RearWheelDriveConfiguration