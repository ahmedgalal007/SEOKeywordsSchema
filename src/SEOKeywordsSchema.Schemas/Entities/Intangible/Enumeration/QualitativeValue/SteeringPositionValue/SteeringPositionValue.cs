using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.QualitativeValues;
public class SteeringPositionValue : QualitativeValue
{
    public override string TypeName { get; protected set; } = nameof(SteeringPositionValue);
}


// TODO Member LeftHandDriving
// TODO Member RightHandDriving