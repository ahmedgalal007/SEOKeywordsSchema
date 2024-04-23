using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations;
public class GamePlayMode : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(GamePlayMode);
}


// TODO Member CoOp
// TODO Member MultiPlayer
// TODO Member SinglePlayer