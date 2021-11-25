// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceTransportConnectionTagHelper
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
  [HtmlTargetElement("connection", ParentTag = "transport", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class PivotDataSourceTransportConnectionTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotDataSourceTransportSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PivotDataSourceTransportSettingsTagHelper).Connection = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string cube = this.Cube;
      if ((cube != null ? (cube.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cube"] = (object) this.Cube;
      string catalog = this.Catalog;
      if ((catalog != null ? (catalog.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["catalog"] = (object) this.Catalog;
      return dictionary;
    }

    public string Cube { get; set; }

    public string Catalog { get; set; }
  }
}
