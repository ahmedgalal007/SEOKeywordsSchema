using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Articles.TechArticles;
public class APIReference: TechArticle
{
    public override string TypeName { get; protected set; } = nameof(APIReference);
}
