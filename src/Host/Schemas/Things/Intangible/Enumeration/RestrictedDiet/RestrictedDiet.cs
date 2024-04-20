using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations;
public class RestrictedDiet : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(RestrictedDiet);
}


// TODO Member DiabeticDiet
// TODO Member GlutenFreeDiet
// TODO Member HalalDiet
// TODO Member HinduDiet
// TODO Member KosherDiet
// TODO Member LowCalorieDiet
// TODO Member LowFatDiet
// TODO Member LowLactoseDiet
// TODO Member LowSaltDiet
// TODO Member VeganDiet
// TODO Member VegetarianDiet