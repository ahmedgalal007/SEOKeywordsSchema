using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles;
public class DefinedTerm : Intangible
{
    public override string TypeName { get; protected set; } = nameof(DefinedTerm);
}

// TODO CategoryCode
