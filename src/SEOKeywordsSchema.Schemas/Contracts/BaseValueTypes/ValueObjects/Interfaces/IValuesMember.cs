using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;

public interface IValuesMember<T> : IValuesMember<DefaultIdType, T>{ }
public interface IValuesMember<TID,T>
{
    public TID Id { get; set; }

    public T Update(T value); 
    public T Delete(TID id);
}
