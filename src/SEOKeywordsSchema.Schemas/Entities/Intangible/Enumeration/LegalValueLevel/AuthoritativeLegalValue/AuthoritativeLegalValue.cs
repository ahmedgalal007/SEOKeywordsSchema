using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.LegalValueLevels;
public class AuthoritativeLegalValue : LegalValueLevel
{
    public override string TypeName { get; protected set; } = nameof(AuthoritativeLegalValue);
}
