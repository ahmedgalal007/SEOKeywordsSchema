using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Extensions;
public static class GenericListUpdateExtension
{
    internal static void Update<T>(this List<T>? oldList, List<T>? newList, bool withRemove = true)
        where T : IValuesMember<T>
    {
        if (newList is null)
        {
            oldList?.Clear();
            oldList = null;
            return;
        }

        newList.ForEach(nL =>
        {
            if (oldList?.Any(oL => oL.Id.Equals(nL.Id)) ?? false)
            {
                oldList?.First(e => e.Id.Equals(nL.Id)).Update(nL);
            }
            else
            {
                oldList?.Add(nL);
            };
        });

        if (withRemove)
            oldList?.ForEach(oL =>
            {
                // if old item Id not exisits in new item remove it
                if (oL.Id != default && !newList.Any(nL => nL.Id.Equals(nL.Id)))
                {
                    oL.Delete(oL.Id);
                    oldList.Remove(oL);
                }
            });
    }
}
