using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks;
public class ArchiveComponent : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(ArchiveComponent);
}
