using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.Articles.ScholarlyArticles;
public class MedicalScholarlyArticle: ScholarlyArticle 
{
    public override string TypeName { get; protected set; } = nameof(MedicalScholarlyArticle);
}
