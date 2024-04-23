using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.DayOfWeekS;
public class Saturday : DayOfWeek
{
    public override string TypeName { get; protected set; } = nameof(Saturday);
}
