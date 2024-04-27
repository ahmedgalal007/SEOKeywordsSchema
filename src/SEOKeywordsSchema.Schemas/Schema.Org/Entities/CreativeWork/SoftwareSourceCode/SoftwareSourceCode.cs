using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.SoftwareSourceCode;
public class SoftwareSourceCode : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(SoftwareSourceCode);
}
