using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Events;
public class ChildrensEvent : Event
{
    public override string TypeName { get; protected set; } = nameof(ChildrensEvent);
}
