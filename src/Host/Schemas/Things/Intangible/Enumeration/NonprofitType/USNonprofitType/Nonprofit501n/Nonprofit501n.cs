using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.NonprofitTypes.USNonprofitTypes;
public class Nonprofit501n : USNonprofitType
{
    public override string TypeName { get; protected set; } = nameof(Nonprofit501n);
}
