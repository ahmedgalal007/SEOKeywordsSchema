using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.GenderType.Male;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Extensions;
public static class IVaulesMemberExtensions
{
    //public static bool Equales<T>(this List<T> lst, List<object>? newList)
    //    where T : ValueObject, IValuesMember<T>
    //{
    //    return false;
    //}

    public static void Update<T>(this IValuesMember<T> instance, T value)
        where T : BaseSchemaEntity, IValuesMember<T>
    {
        //var t = instance.GetType();

        if (instance?.Value?.GetType().IsSimpleType() ?? false && value.GetType().IsSimpleType())
        {
            instance.Value = value;
        }
        else
        {
            if (instance.GetType().IsAssignableFrom(value.GetType()))
            {
                instance.Update(value);
            }
        }
        //MethodInfo? _update = instance?.Value?.GetType().GetMethod("Update");
        //                      // value?.GetType().GetMethod("Update");
        //if (_update != null)
        //{
        //    _update.Invoke(instance.Value, new object[] { value });
        //}

    }
    public static void Delete<T>(this IValuesMember<T> instance, DefaultIdType id)
        where T : class
    {
        instance.Value = null;
    }


}

    
