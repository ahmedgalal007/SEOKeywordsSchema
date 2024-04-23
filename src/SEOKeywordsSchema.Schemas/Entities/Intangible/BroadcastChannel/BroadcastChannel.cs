using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles;
public class BroadcastChannel : Intangible
{
    public override string TypeName { get; protected set; } = nameof(BroadcastChannel);
}



// TODO RadioChannel
// TODO TelevisionChannel