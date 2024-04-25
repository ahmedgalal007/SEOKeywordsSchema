using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
public interface IValuesProperty<T>: IValuesProperty<DefaultIdType, T>{ }
public interface IValuesProperty<TID,T>
{
    public TID Id { get; set; }
    public static abstract T Create(T value);
    public T Update(T value);
    public T Delete(TID id);
}
