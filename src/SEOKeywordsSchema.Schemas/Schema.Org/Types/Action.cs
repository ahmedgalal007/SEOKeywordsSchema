//using Microsoft.EntityFrameworkCore;
//using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
//using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
//using Action = SEOKeywordsSchema.Schemas.SchemaEntities.Action;

//namespace SEOKeywordsSchema.Schemas.Types;

//[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<Action>))]
//public class Action :  ValueObject, ISchemaType<URL>, 
//                       IValuesMember<Action>
//{
//    public DefaultIdType Id { get; set; }

//    protected Action()
//    {

//    }
//    public Action(List<Action> actions)
//    {

//    }

//    public Action Update(Action value)
//    {
//        return this;
//    }

//    public Action Delete(DefaultIdType id)
//    {
//        return this;
//    }

//    protected override IEnumerable<Object> GetEqualityComponents()
//    {
//        yield return Id;
//    }
//}
