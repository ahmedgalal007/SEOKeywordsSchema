﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.MapCategoryTypes;
public class ParkingMap : MapCategoryType
{
    public override string TypeName { get; protected set; } = nameof(ParkingMap);
}
