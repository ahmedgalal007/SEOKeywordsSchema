using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.GamePlayModes;
public class SinglePlayer : GamePlayMode
{
    public override string TypeName { get; protected set; } = nameof(SinglePlayer);
}
