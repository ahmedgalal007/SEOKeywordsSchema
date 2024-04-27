using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.ReturnMethodEnumerations;
public class ReturnByMail : ReturnMethodEnumeration
{
    public override string TypeName { get; protected set; } = nameof(ReturnByMail);
}
