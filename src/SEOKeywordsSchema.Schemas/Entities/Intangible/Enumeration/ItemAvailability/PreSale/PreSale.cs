using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.ItemAvailabilities;
public class PreSale : ItemAvailability
{
    public override string TypeName { get; protected set; } = nameof(PreSale);
}
