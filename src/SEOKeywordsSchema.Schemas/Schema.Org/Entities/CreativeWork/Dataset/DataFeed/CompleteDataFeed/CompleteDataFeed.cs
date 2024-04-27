using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Dataset.DataFeed;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Dataset.DataFeed.CompleteDataFeed;
public class CompleteDataFeed : DataFeed
{
    public override string TypeName { get; protected set; } = nameof(CompleteDataFeed);
}
