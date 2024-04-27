using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Dataset;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Dataset.DataFeed;
public class DataFeed : Dataset
{
    public override string TypeName { get; protected set; } = nameof(DataFeed);
}
