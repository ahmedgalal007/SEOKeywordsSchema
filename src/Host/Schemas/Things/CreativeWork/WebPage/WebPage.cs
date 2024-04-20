using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks;
public class WebPage : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(WebPage);
}


// TODO AboutPage
// TODO CheckoutPage
// TODO CollectionPage
// TODO ContactPage
// TODO FAQPage
// TODO ItemPage
// TODO MedicalWebPage
// TODO ProfilePage
// TODO QAPage
// TODO RealEstateListing
// TODO SearchResultsPage