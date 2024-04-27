using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.DefinedTerm;
public class DefinedTerm : Intangible
{
    public override string TypeName { get; protected set; } = nameof(DefinedTerm);
}

// TODO CategoryCode
