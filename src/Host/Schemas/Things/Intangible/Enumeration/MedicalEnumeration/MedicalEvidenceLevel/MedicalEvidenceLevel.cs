﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations;
public class MedicalEvidenceLevel : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalEvidenceLevel);
}

// TODO Member EvidenceLevelA
// TODO Member EvidenceLevelB
// TODO Member EvidenceLevelC