﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.EnergyEfficiencyEnumerations;
public class EnergyStarEnergyEfficiencyEnumeration : EnergyEfficiencyEnumeration
{
    public override string TypeName { get; protected set; } = nameof(EnergyStarEnergyEfficiencyEnumeration);
}


// TODO Member EnergyStarCertified
