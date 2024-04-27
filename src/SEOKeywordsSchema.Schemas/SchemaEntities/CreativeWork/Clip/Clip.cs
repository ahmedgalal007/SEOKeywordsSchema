using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
public class Clip : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(Clip);
}

// TODO MovieClip
// TODO RadioClip
// TODO TVClip
// TODO VideoGameClip
