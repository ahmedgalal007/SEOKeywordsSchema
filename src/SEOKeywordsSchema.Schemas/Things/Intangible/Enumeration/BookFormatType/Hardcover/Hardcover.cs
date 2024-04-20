using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.BookFormatTypes;
public class Hardcover : BookFormatType
{
    public override string TypeName { get; protected set; } = nameof(Hardcover);
}
