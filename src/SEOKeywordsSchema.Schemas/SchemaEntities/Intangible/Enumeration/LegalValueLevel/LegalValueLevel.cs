using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations;
public class LegalValueLevel : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(LegalValueLevel);
}


// TODO Member AuthoritativeLegalValue
// TODO Member DefinitiveLegalValue
// TODO Member OfficialLegalValue
// TODO Member UnofficialLegalValue