using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.GamePlayMode;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.GamePlayMode.SinglePlayer;
public class SinglePlayer : GamePlayMode
{
    public override string TypeName { get; protected set; } = nameof(SinglePlayer);
}
