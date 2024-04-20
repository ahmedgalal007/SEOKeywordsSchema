using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations;
public class DigitalDocumentPermissionType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(DigitalDocumentPermissionType);
}


// TODO Members CommentPermission
// TODO Members ReadPermission
// TODO Members WritePermission