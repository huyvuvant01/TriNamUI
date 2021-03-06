// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnExportableSettingsTagHelper
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
  [HtmlTargetElement("exportable", ParentTag = "column", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class GridColumnExportableSettingsTagHelper : TagHelperChildBase
  {
    public GridColumnExportableSettingsTagHelper()
    {
      this.Enabled = true;
      this.Excel = true;
      this.Pdf = true;
    }

    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridColumnTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridColumnTagHelper).Exportable = this;
    }

    public bool Enabled { get; set; }

    public bool Excel { get; set; }

    public bool Pdf { get; set; }

    internal Dictionary<string, object> SerializeSettings() => new Dictionary<string, object>()
    {
      ["excel"] = (object) this.Excel,
      ["pdf"] = (object) this.Pdf
    };
  }
}
