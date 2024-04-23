using SEOKeywordsSchema.Schemas.Things;
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
    // protected bool IsLeafe { get; set; }
    public virtual bool IsLeafe() { return false; }
    public virtual static BaseSchemaEntity? GetParent(ISchemaEntity instance) { return instance.Parent; }
    public virtual static Stack<BaseSchemaEntity> GetParents() { return new Stack<BaseSchemaEntity>(); }
    public virtual static List<BaseSchemaEntity>? GetChildrensStatic(ISchemaEntity instance) {
        var type = typeof(ISchemaEntity);
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => type.IsAssignableFrom(p) && 
                    p.GetType().IsSubclassOf(typeof(BaseSchemaEntity)) &&
                    p.GetProperty("Parent") is not null &&
                    p.GetProperty("Parent")!.GetType()  == instance.GetType() );
        // return new List<BaseSchemaEntity>(); 
        return  types as List<BaseSchemaEntity>; 
    }
    public virtual List<BaseSchemaEntity> GetSiblings() { return new List<BaseSchemaEntity>(); }
}

public static class BaseSchemaEntityClassExtentions
{
    public static void TestThing()
    {
        ISchemaEntity thing = new Thing();
        thing.GetChildrens();
        thing.GetChildrensExt();
        Thing thing2 = new Thing();
    }
    public static List<BaseSchemaEntity>? GetChildrensExt (this ISchemaEntity instance) {
        var type = typeof(ISchemaEntity);
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => type.IsAssignableFrom(p) &&
                    p.GetType().IsSubclassOf(typeof(BaseSchemaEntity)) &&
                    p.GetProperty("Parent") is not null &&
                    p.GetProperty("Parent")!.GetType() == instance.GetType());
        // return new List<BaseSchemaEntity>(); 
        return types as List<BaseSchemaEntity>;
    }
    public static List<BaseSchemaEntity>? GetChildrens(this ISchemaEntity instance)
    {
        var type = typeof(ISchemaEntity);
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => type.IsAssignableFrom(p) &&
                    p.GetType().IsSubclassOf(typeof(BaseSchemaEntity)) &&
                    p.GetProperty("Parent") is not null &&
                    p.GetProperty("Parent")!.GetType() == instance.GetType());
        // return new List<BaseSchemaEntity>(); 
        return types as List<BaseSchemaEntity>;
    }
}
