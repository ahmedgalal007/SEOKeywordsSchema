using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Events;
public class ComedyEvent : Event
{
    public override string TypeName { get; protected set; } = nameof(ComedyEvent);
}
