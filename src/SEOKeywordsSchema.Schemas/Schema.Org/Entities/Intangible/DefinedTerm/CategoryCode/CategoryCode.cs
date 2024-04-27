using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.DefinedTerm;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.DefinedTerm.CategoryCode;
public class CategoryCode : DefinedTerm
{
    public override string TypeName { get; protected set; } = nameof(CategoryCode);
}
