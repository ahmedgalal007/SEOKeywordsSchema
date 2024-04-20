using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.HowTos;
public class Recipe: HowTo
{
    public override string TypeName { get; protected set; } = nameof(Recipe);
}