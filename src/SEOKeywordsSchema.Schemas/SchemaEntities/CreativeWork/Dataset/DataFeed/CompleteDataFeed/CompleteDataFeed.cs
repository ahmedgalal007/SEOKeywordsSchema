using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Datasets.DataFeeds;
public class CompleteDataFeed : DataFeed
{
    public override string TypeName { get; protected set; } = nameof(CompleteDataFeed);
}
