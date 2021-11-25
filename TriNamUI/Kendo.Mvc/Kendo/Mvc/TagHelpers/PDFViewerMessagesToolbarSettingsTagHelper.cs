// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PDFViewerMessagesToolbarSettingsTagHelper
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
  [HtmlTargetElement("toolbar", ParentTag = "messages", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("pager", new string[] {})]
  [SuppressTagRendering]
  public class PDFViewerMessagesToolbarSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PDFViewerMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PDFViewerMessagesSettingsTagHelper).Toolbar = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Open { get; set; }

    public string ExportAs { get; set; }

    public string Download { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerMessagesToolbarPagerSettingsTagHelper Pager { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string open = this.Open;
      if ((open != null ? (open.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.Open;
      string exportAs = this.ExportAs;
      if ((exportAs != null ? (exportAs.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["exportAs"] = (object) this.ExportAs;
      string download = this.Download;
      if ((download != null ? (download.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["download"] = (object) this.Download;
      if (this.Pager != null)
      {
        Dictionary<string, object> source = this.Pager.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["pager"] = (object) source;
      }
      return dictionary;
    }
  }
}
