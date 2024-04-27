using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.SizeSystemEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.SizeSystemEnumeration.SizeSystemMetric;
public class SizeSystemMetric : SizeSystemEnumeration
{
    public override string TypeName { get; protected set; } = nameof(SizeSystemMetric);
}
