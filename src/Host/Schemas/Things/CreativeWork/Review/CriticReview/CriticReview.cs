using System;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Reviews;
public class CriticReview : Review
{
    public override string TypeName { get; protected set; } = nameof(CriticReview);
}
