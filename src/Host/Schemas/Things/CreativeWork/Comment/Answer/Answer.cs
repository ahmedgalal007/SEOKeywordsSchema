using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Comments;
public class Answer : Comment
{
    public override string TypeName { get; protected set; } = nameof(Answer);
}

