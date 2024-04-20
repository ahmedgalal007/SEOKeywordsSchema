using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.QualitativeValues;
public class SizeSpecification : QualitativeValue
{
    public override string TypeName { get; protected set; } = nameof(SizeSpecification);
}
