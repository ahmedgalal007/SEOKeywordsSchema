﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations;
public class ReturnLabelSourceEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(ReturnLabelSourceEnumeration);
}


// TODO Member ReturnLabelCustomerResponsibility
// TODO Member ReturnLabelDownloadAndPrint
// TODO Member ReturnLabelInBox