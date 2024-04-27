using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Comment;
public class Comment : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(Comment);
}

// TODO Answer
// TODO CorrectionComment
// TODO Question
