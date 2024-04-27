using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.ConstraintNode;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.ConstraintNode.StatisticalVariable;
public class StatisticalVariable : ConstraintNode
{
    public override string TypeName { get; protected set; } = nameof(StatisticalVariable);
}


// TODO StatisticalVariable