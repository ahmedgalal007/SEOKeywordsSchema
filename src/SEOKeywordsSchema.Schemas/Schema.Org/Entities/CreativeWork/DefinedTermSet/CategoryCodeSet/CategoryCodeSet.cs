using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.DefinedTermSet;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.DefinedTermSet.CategoryCodeSet;
public class CategoryCodeSet : DefinedTermSet
{
    public override string TypeName { get; protected set; } = nameof(CategoryCodeSet);
}
