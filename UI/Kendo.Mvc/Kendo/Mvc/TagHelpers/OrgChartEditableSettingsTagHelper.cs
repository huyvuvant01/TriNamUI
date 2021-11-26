// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.OrgChartEditableSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("editable", ParentTag = "kendo-orgchart", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("kendo-form", new string[] {})]
  [SuppressTagRendering]
  public class OrgChartEditableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (OrgChartTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as OrgChartTagHelper).Editable = this;
    }

    [HtmlAttributeNotBound]
    public Dictionary<string, object> Form { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Form != null)
        dictionary["form"] = (object) this.Form;
      return dictionary;
    }

    public bool? Enabled { get; set; }

    public bool? Create { get; set; }

    public bool? Destroy { get; set; }

    public bool? Fields { get; set; }

    public bool? Parent { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Create.HasValue)
        dictionary["create"] = (object) this.Create;
      if (this.Destroy.HasValue)
        dictionary["destroy"] = (object) this.Destroy;
      if (this.Fields.HasValue)
        dictionary["fields"] = (object) this.Fields;
      if (this.Parent.HasValue)
        dictionary["parent"] = (object) this.Parent;
      return dictionary;
    }
  }
}
