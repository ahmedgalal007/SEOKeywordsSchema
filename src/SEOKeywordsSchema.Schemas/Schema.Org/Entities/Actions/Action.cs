using System;
using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Actions;

[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<Action>))]
public class Action : BaseSchemaEntity, ISchemaEntity
{
    // public override string TypeName { get; protected set; } = nameof(Action);
}


// TODO AchieveAction
// TODO AssessAction
// TODO ConsumeAction
// TODO ControlAction
// TODO CreateAction
// TODO FindAction
// TODO InteractAction
// TODO MoveAction
// TODO OrganizeAction
// TODO PlayAction
// TODO SearchAction
// TODO SeekToAction
// TODO SolveMathAction
// TODO TradeAction
// TODO TransferAction
// TODO UpdateAction