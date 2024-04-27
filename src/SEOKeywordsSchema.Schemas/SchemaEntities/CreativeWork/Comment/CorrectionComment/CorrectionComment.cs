using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Comments;
public class CorrectionComment : Comment
{
    public override string TypeName { get; protected set; } = nameof(CorrectionComment);
}

