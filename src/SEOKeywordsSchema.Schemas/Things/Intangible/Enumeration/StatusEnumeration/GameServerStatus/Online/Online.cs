
using SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.StatusEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.StatusEnumerations;
public class Online : GameServerStatus
{
    public override string TypeName { get; protected set; } = nameof(Online);
}
