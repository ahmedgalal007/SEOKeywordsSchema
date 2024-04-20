using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.DayOfWeekS;
public class Monday : DayOfWeek
{
    public override string TypeName { get; protected set; } = nameof(Monday);
}
