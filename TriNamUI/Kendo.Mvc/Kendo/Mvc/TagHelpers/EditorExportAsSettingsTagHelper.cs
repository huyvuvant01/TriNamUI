// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorExportAsSettingsTagHelper
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
  [HtmlTargetElement("export-as", ParentTag = "kendo-editor", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("export-as", ParentTag = "richtexteditor-editor", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class EditorExportAsSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string FileName { get; set; }

    public string Proxy { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (EditorTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorTagHelper).ExportAs = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (!string.IsNullOrEmpty(this.Proxy))
        dictionary["proxyURL"] = (object) this.Proxy;
      if (!string.IsNullOrEmpty(this.FileName))
        dictionary["fileName"] = (object) this.FileName;
      return dictionary;
    }
  }
}
