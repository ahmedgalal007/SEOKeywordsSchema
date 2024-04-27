using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
public class Map : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(Map);
}
