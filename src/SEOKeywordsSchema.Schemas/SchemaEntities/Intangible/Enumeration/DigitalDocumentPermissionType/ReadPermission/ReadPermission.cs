using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.DigitalDocumentPermissionTypes;
public class ReadPermission : DigitalDocumentPermissionType
{
    public override string TypeName { get; protected set; } = nameof(ReadPermission);
}
