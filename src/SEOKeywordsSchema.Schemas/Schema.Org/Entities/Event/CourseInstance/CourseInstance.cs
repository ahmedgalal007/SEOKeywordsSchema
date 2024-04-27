using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Event;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Event.CourseInstance;
public class CourseInstance : Event
{
    public override string TypeName { get; protected set; } = nameof(CourseInstance);
}
