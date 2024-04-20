using Microsoft.Data.SqlClient.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations;
public class MusicReleaseFormatType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(MusicReleaseFormatType);
}


// TODO Member CDFormat
// TODO Member CassetteFormat
// TODO Member DVDFormat
// TODO Member DigitalAudioTapeFormat
// TODO Member DigitalFormat
// TODO Member LaserDiscFormat
// TODO Member VinylFormat