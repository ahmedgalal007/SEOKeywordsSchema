using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.GamePlayMode;
public class GamePlayMode : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(GamePlayMode);
}


// TODO Member CoOp
// TODO Member MultiPlayer
// TODO Member SinglePlayer