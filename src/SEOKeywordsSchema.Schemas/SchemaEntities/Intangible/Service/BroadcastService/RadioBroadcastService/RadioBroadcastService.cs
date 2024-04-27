using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Services.BroadcastServices;
public class RadioBroadcastService : BroadcastService
{
    public override string TypeName { get; protected set; } = nameof(RadioBroadcastService);
}
