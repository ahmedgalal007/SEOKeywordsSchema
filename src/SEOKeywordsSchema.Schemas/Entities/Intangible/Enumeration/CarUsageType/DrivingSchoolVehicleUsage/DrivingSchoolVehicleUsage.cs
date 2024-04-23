using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.CarUsageTypes;
public class DrivingSchoolVehicleUsage : CarUsageType
{
    public override string TypeName { get; protected set; } = nameof(DrivingSchoolVehicleUsage);
}
