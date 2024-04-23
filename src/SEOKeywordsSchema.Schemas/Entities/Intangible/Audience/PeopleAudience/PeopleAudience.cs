using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Audiences;
public class PeopleAudience : Audience
{
    public override string TypeName { get; protected set; } = nameof(PeopleAudience);
}

