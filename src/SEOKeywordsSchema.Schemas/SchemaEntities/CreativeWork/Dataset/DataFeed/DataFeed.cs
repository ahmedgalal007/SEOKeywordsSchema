using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Datasets;
public class DataFeed : Dataset
{
    public override string TypeName { get; protected set; } = nameof(DataFeed);
}
