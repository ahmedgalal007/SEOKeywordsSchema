using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks;
public class Review : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(Review);
}


// TODO ClaimReview
// TODO CriticReview
// TODO EmployerReview
// TODO MediaReview
// TODO Recommendation
// TODO UserReview