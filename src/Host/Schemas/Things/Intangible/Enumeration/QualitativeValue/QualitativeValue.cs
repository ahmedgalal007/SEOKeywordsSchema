﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations;
public class QualitativeValue : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(QualitativeValue);
}

// TODO BedType
// TODO DriveWheelConfigurationValue
// TODO SizeSpecification
// TODO SteeringPositionValue