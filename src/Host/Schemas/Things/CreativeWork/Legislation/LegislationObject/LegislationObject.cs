using System;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Legislations;
public class LegislationObject: Legislation
{
    public override string TypeName { get; protected set; } = nameof(LegislationObject);
}
