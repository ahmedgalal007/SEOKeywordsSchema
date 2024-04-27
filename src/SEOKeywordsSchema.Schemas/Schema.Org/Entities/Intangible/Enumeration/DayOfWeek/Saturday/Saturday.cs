using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.DayOfWeek;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.DayOfWeek.Saturday;
public class Saturday : DayOfWeek
{
    public override string TypeName { get; protected set; } = nameof(Saturday);
}
