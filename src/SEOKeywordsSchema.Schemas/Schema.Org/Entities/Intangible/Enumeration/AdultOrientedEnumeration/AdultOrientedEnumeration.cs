﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.AdultOrientedEnumeration;
public class AdultOrientedEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(AdultOrientedEnumeration);
}



// TODO AlcoholConsideration
// TODO DangerousGoodConsideration
// TODO HealthcareConsideration
// TODO NarcoticConsideration
// TODO ReducedRelevanceForChildrenConsideration
// TODO SexualContentConsideration
// TODO TobaccoNicotineConsideration
// TODO UnclassifiedAdultConsideration
// TODO ViolenceConsideration
// TODO WeaponConsideration