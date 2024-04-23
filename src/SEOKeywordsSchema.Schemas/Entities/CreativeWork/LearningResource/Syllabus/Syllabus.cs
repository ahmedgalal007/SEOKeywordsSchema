using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.LearningResources;
public class Syllabus : LearningResource
{
    public override string TypeName { get; protected set; } = nameof(Syllabus);
}
