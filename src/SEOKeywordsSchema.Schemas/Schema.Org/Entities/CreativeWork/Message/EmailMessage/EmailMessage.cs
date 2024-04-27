using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Message;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Message.EmailMessage;
public class EmailMessage : Message
{
    public override string TypeName { get; protected set; } = nameof(EmailMessage);
}
