﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations;
public class DrugCostCategory : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(DrugCostCategory);
}


// TODO Member ReimbursementCap
// TODO Member Retail
// TODO Member Wholesale