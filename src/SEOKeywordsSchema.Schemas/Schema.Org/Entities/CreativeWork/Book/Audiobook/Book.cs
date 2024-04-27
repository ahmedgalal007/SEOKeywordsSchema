using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Book;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Book.Audiobook;
public class Audiobook : Book
{
    public override string TypeName { get; protected set; } = nameof(Audiobook);
}
