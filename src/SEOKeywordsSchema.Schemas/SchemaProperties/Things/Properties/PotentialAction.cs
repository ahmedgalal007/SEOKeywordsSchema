using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using Action = SEOKeywordsSchema.Schemas.SchemaEntities.Action;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;

[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<PotentialAction>))]
public class PotentialAction : List<Action>, ISchemaProperty<PotentialAction> {

    protected PotentialAction():base()
    {
            
    }
    public PotentialAction(Action action) : base(new List<Action> { action })
    {

    }
    public PotentialAction(IEnumerable<Action> actions):base(actions)
    {
            
    }
}