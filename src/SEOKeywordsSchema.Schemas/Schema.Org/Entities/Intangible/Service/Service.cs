using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Service;
public class Service : Intangible
{
    public override string TypeName { get; protected set; } = nameof(Service);
}


// TODO BroadcastService
// TODO CableOrSatelliteService
// TODO FinancialProduct
// TODO FoodService
// TODO GovernmentService
// TODO TaxiService
// TODO WebAPI