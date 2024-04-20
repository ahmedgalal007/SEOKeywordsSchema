using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations;
public class BookFormatType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(BookFormatType);
}


// TODO AudiobookFormat
// TODO EBook
// TODO GraphicNovel
// TODO Hardcover
// TODO Paperback