using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.DefinedTerms;
public class CategoryCode : DefinedTerm
{
    public override string TypeName { get; protected set; } = nameof(CategoryCode);
}
