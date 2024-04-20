using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks;
public class Comment : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(Comment);
}

// TODO Answer
// TODO CorrectionComment
// TODO Question
