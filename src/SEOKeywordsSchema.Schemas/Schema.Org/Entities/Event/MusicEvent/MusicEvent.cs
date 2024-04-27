using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Event;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Event.MusicEvent;
public class MusicEvent : Event
{
    public override string TypeName { get; protected set; } = nameof(MusicEvent);
}
