using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Collection;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Collection.ProductCollection;
public class ProductCollection : Collection
{
    public override string TypeName { get; protected set; } = nameof(ProductCollection);
}

