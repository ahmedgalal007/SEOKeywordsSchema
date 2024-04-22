//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.ValueObjects.Contracts;
//public abstract class BaseMixedValueProperty : ValueObjectWithId , IEquatable<BaseMixedValueProperty>
//{
//    public virtual bool IsSingle { get; set; }

//    protected abstract object? GetSingleValue();
//    // protected new abstract override IEnumerable<Object> GetEqualityComponents();

//    public override Boolean Equals(Object? obj)
//    {
//        return base.Equals(obj);
//    }
//    public virtual Boolean Equals(BaseMixedValueProperty? obj)
//    {
//        if (base.Equals(obj)) return true;
//        if (IsSingle && obj.IsSingle  && GetType() == typeof(BaseMixedValueProperty))
//        {
//                return obj.GetSingleValue().Id != default && Id.Equals(obj.Id);
//        }
//        return false;
//    }

//    public static bool IsGenericList(object o)
//    {
//        var oType = o.GetType();
//        return (oType.IsGenericType && (oType.GetGenericTypeDefinition() == typeof(List<>)));
//    }

//    public override int GetHashCode()
//    {
//        base.GetHashCode(); 
//        return Id.GetHashCode();    
//    }
//}
