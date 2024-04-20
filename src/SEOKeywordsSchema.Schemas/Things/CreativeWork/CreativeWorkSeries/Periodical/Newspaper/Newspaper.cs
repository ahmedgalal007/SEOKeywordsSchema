using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.CreativeWorkSerieses.Periodicals;
public class Newspaper : Periodical
{
    public override string TypeName { get; protected set; } = nameof(Newspaper);
}
