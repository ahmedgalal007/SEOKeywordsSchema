﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.CreativeWorks;
public class DigitalDocument : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(DigitalDocument);
}


// TODO NoteDigitalDocument
// TODO PresentationDigitalDocument
// TODO SpreadsheetDigitalDocument
// TODO TextDigitalDocument