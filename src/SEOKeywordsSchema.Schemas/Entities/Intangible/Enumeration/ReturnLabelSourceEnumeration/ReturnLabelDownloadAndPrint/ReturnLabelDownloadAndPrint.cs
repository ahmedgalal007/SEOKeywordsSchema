using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.ReturnLabelSourceEnumerations;
public class ReturnLabelDownloadAndPrint : ReturnLabelSourceEnumeration
{
    public override string TypeName { get; protected set; } = nameof(ReturnLabelDownloadAndPrint);
}
