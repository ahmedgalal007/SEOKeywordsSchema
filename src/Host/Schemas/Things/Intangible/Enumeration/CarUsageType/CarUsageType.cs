﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations;
public class CarUsageType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(CarUsageType
        );
}


// TODO DrivingSchoolVehicleUsage
// TODO RentalVehicleUsage
// TODO TaxiVehicleUsage