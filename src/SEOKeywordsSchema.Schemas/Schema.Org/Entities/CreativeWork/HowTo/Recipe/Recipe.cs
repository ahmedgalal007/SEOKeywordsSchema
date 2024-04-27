using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.HowTo;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.HowTo.Recipe;
public class Recipe : HowTo
{
    public override string TypeName { get; protected set; } = nameof(Recipe);
}