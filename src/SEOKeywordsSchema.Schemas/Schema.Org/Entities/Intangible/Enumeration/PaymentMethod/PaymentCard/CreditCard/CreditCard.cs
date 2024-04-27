using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PaymentMethod.PaymentCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PaymentMethod.PaymentCard.CreditCard;
public class CreditCard : PaymentCard
{
    public override string TypeName { get; protected set; } = nameof(CreditCard);
}


// Common Values http://purl.org/goodrelations/v1#AmericanExpress
// Common Values http://purl.org/goodrelations/v1#DinersClub
// Common Values http://purl.org/goodrelations/v1#Discover
// Common Values http://purl.org/goodrelations/v1#JCB
// Common Values http://purl.org/goodrelations/v1#MasterCard
// Common Values http://purl.org/goodrelations/v1#VISA