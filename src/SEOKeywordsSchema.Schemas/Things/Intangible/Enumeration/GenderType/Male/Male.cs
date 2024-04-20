using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.GenderTypes;
public class Male : GenderType
{
    public override string TypeName { get; protected set; } = nameof(Male);
}
