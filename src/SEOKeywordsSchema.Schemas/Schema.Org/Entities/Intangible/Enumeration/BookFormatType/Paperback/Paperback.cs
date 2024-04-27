using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.BookFormatType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.BookFormatType.Paperback;
public class Paperback : BookFormatType
{
    public override string TypeName { get; protected set; } = nameof(Paperback);
}
