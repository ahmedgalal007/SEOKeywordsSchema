using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Contracts;
public interface ISchemaEntity
{
    public string SchemaType { get; set; }
    public virtual BaseSchemaEntity? Parent { get { return null; } set{ } }
    // public bool IsLeafe { get; set; }
    public bool IsLeafe();
    public virtual BaseSchemaEntity? GetParent() { return Parent; }
    public virtual Stack<BaseSchemaEntity> GetParents() { return new Stack<BaseSchemaEntity>(); }
    public virtual List<BaseSchemaEntity> GetChildrens() { return new List<BaseSchemaEntity>(); }
    public virtual List<BaseSchemaEntity> GetSiblings() { return new List<BaseSchemaEntity>(); }
}
