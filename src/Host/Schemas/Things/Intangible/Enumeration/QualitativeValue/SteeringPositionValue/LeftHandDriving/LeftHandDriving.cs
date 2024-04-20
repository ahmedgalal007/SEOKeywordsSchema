using FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.QualitativeValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.QualitativeValues.SteeringPositionValues;
public class LeftHandDriving : SteeringPositionValue
{
    public override string TypeName { get; protected set; } = nameof(LeftHandDriving);
}
