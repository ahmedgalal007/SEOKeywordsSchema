using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.LegalValueLevel;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.LegalValueLevel.DefinitiveLegalValue;
public class DefinitiveLegalValue : LegalValueLevel
{
    public override string TypeName { get; protected set; } = nameof(DefinitiveLegalValue);
}
