﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.GovernmentBenefitsType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.GovernmentBenefitsType.BasicIncome;
public class BasicIncome : GovernmentBenefitsType
{
    public override string TypeName { get; protected set; } = nameof(BasicIncome);
}
