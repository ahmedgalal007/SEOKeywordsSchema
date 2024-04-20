using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.ConstraintNodes;
public class StatisticalVariable : ConstraintNode
{
    public override string TypeName { get; protected set; } = nameof(StatisticalVariable);
}


// TODO StatisticalVariable