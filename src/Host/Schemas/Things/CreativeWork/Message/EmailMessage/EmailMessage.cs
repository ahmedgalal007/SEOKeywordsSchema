﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks.Messages;
public class EmailMessage: Message
{
    public override string TypeName { get; protected set; } = nameof(EmailMessage);
}