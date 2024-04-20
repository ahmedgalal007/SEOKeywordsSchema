using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.ComicIssues;
public class ComicIssue: PublicationIssue
{
    public override string TypeName { get; protected set; } = nameof(ComicIssue);
}
