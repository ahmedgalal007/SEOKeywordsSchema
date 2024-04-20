using System;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Reviews;
public class UserReview : Review
{
    public override string TypeName { get; protected set; } = nameof(UserReview);
}
