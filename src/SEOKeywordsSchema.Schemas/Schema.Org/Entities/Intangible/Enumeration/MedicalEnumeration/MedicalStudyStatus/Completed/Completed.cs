﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalStudyStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalStudyStatus.Completed;
public class Completed : MedicalStudyStatus
{
    public override string TypeName { get; protected set; } = nameof(Completed);
}
