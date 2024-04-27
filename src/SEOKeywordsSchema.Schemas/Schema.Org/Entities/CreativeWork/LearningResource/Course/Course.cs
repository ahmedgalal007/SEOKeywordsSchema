using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.LearningResource;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.LearningResource.Course;
public class Course : LearningResource
{
    public override string TypeName { get; protected set; } = nameof(Course);
}
