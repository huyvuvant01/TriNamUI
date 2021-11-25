// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridToolbarButtonTagHelper
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
  [HtmlTargetElement("toolbar-button", ParentTag = "toolbar", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class GridToolbarButtonTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridToolbarTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridToolbarTagHelper).Add(this);
    }

    public string IconClass { get; set; }

    public string Name { get; set; }

    public string Text { get; set; }

    public string Template { get; set; }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.IconClass.HasValue())
        dictionary["iconClass"] = (object) this.IconClass;
      if (this.Text.HasValue())
        dictionary["text"] = (object) this.Text;
      if (this.Name.HasValue())
        dictionary["name"] = (object) this.Name;
      string template = this.Template;
      if ((template != null ? (template.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.Template
        };
      return dictionary;
    }
  }
}
