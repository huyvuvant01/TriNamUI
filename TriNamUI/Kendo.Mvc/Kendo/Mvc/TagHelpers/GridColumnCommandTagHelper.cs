// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnCommandTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("column-command", ParentTag = "commands", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class GridColumnCommandTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridColumnCommandsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridColumnCommandsTagHelper).Add(this);
    }

    public string Visible { get; set; }

    public string Click { get; set; }

    public string Name { get; set; }

    public string IconClass { get; set; }

    public string ClassName { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Text { get; set; }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Name.HasValue())
        dictionary["name"] = (object) this.Name;
      if (this.ClassName.HasValue())
        dictionary["className"] = (object) this.ClassName;
      if (this.IconClass.HasValue())
        dictionary["iconClass"] = (object) this.IconClass;
      if (this.Text.HasValue())
        dictionary["text"] = (object) this.Text;
      string click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.Click
        };
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      string visible = this.Visible;
      if ((visible != null ? (visible.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visible"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.Visible
        };
      return dictionary;
    }
  }
}
