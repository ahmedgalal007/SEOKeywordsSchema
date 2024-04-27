using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.BroadcastChannel;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.BroadcastChannel.TelevisionChannel;
public class TelevisionChannel : BroadcastChannel
{
    public override string TypeName { get; protected set; } = nameof(TelevisionChannel);
}
