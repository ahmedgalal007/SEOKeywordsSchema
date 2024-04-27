using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.PublicationIssue;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.PublicationIssue.ComicIssue;
public class ComicIssue : PublicationIssue
{
    public override string TypeName { get; protected set; } = nameof(ComicIssue);
}
