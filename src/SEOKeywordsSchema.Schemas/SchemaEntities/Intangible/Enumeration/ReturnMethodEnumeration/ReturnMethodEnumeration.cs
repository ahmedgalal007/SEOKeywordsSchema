﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations;
public class ReturnMethodEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(ReturnMethodEnumeration);
}


// TODO Member ReturnAtKiosk
// TODO Member ReturnByMail
// TODO Member ReturnInStore