using Host.Schemas.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things;
public class Person : Thing, IPersonProperty
{
    public override string TypeName { get; protected set; } = nameof(Person);
    public string AdditionalName { get; set; }
    public Organization Affiliation { get; set; }
    public string award { get; set; }
    public string duns { get; set; }
    public string Email { get; set; }
    public string FamilyName { get; set; }
    public string FaxNumber { get; set; }
    public Place BirthPlace { get; set; }
    public Person Follows { get; set; }

}
