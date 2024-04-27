using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.ScholarlyArticle;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Articles.ScholarlyArticle.MedicalScholarlyArticle;
public class MedicalScholarlyArticle : ScholarlyArticle
{
    public override string TypeName { get; protected set; } = nameof(MedicalScholarlyArticle);
}
