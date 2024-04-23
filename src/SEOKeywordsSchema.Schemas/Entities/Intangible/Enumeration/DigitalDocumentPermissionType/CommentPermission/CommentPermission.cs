using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.DigitalDocumentPermissionTypes;
public class CommentPermission : DigitalDocumentPermissionType
{
    public override string TypeName { get; protected set; } = nameof(CommentPermission);
}
