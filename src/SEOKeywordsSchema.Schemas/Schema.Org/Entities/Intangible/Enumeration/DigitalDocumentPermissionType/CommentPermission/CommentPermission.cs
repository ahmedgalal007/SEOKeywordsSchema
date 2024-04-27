using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.DigitalDocumentPermissionType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.DigitalDocumentPermissionType.CommentPermission;
public class CommentPermission : DigitalDocumentPermissionType
{
    public override string TypeName { get; protected set; } = nameof(CommentPermission);
}
