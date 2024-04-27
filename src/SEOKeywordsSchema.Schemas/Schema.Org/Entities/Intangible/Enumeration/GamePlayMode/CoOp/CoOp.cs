using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.GamePlayMode;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.GamePlayMode.CoOp;
public class CoOp : GamePlayMode
{
    public override string TypeName { get; protected set; } = nameof(CoOp);
}
