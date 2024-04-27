using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration;
using static MassTransit.Util.ChartTable;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.GameServerStatus;
public class GameServerStatus : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(GameServerStatus);
}


// TODO Member OfflinePermanently
// TODO Member OfflineTemporarily
// TODO Member Online
// TODO Member OnlineFull