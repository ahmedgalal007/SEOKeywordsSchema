using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Comment;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Comment.Answer;
public class Answer : Comment
{
    public override string TypeName { get; protected set; } = nameof(Answer);
}

