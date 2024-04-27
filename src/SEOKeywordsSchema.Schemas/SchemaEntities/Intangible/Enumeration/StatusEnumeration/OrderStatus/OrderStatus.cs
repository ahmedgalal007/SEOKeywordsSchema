using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.StatusEnumerations;
public class OrderStatus : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(OrderStatus);
}


// TODO Member OrderCancelled
// TODO Member OrderDelivered
// TODO Member OrderInTransit
// TODO Member OrderPaymentDue
// TODO Member OrderPickupAvailable
// TODO Member OrderProblem
// TODO Member OrderProcessing
// TODO Member OrderReturned