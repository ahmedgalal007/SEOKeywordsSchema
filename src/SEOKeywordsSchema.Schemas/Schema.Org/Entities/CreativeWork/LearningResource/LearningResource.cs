using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.LearningResource;
public class LearningResource : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(LearningResource);
}


// TODO Course
// TODO Quiz
// TODO Syllabus