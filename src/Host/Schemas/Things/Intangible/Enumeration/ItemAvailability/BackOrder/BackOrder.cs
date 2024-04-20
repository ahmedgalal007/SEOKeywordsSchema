using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.ItemAvailabilities;
public class BackOrder : ItemAvailability
{
    public override string TypeName { get; protected set; } = nameof(BackOrder);
}
