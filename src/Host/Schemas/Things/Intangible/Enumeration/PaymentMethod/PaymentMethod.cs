using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations;
public class PaymentMethod : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(PaymentMethod);
}

// TODO PaymentCard

// Common Values http://purl.org/goodrelations/v1#ByBankTransferInAdvance
// Common Values http://purl.org/goodrelations/v1#ByInvoice
// Common Values http://purl.org/goodrelations/v1#Cash
// Common Values http://purl.org/goodrelations/v1#CheckInAdvance
// Common Values http://purl.org/goodrelations/v1#COD
// Common Values http://purl.org/goodrelations/v1#DirectDebit
// Common Values http://purl.org/goodrelations/v1#GoogleCheckout
// Common Values http://purl.org/goodrelations/v1#PayPal
// Common Values http://purl.org/goodrelations/v1#PaySwarm