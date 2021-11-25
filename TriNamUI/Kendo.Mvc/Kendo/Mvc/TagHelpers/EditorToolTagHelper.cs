// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorToolTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("tool", ParentTag = "tools", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("tool-items", new string[] {})]
  [SuppressTagRendering]
  public class EditorToolTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (EditorToolsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorToolsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Name { get; set; }

    public string Tooltip { get; set; }

    public string Exec { get; set; }

    [HtmlAttributeNotBound]
    public EditorToolItemsTagHelper Items { get; set; }

    public string Palette { get; set; }

    public double? Columns { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string tooltip = this.Tooltip;
      if ((tooltip != null ? (tooltip.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["tooltip"] = (object) this.Tooltip;
      string exec = this.Exec;
      if ((exec != null ? (exec.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["exec"] = (object) this.CreateHandler(this.Exec);
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<EditorToolItemTagHelper, Dictionary<string, object>>((Func<EditorToolItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      if (this.Columns.HasValue)
        dictionary["columns"] = (object) this.Columns;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      return dictionary;
    }
  }
}
