using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.PaymentMethods;
public class PaymentCard : PaymentMethod
{
    public override string TypeName { get; protected set; } = nameof(PaymentCard);
}

// TODO CreditCard