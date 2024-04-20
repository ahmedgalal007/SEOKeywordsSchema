using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MassTransit.Util.ChartTable;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.StatusEnumerations;
public class GameServerStatus : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(GameServerStatus);
}


// TODO Member OfflinePermanently
// TODO Member OfflineTemporarily
// TODO Member Online
// TODO Member OnlineFull