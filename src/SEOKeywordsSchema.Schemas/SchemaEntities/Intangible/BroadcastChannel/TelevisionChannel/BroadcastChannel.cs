using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.BroadcastChannels;
public class TelevisionChannel: BroadcastChannel
{
    public override string TypeName { get; protected set; } = nameof(TelevisionChannel);
}
