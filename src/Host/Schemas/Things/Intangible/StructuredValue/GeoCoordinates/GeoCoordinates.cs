using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.StructuredValues;
public class GeoCoordinates : StructuredValue
{
    public override string TypeName { get; protected set; } = nameof(GeoCoordinates);
}
