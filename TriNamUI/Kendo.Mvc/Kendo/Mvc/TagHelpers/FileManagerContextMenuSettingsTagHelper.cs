// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FileManagerContextMenuSettingsTagHelper
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
  [HtmlTargetElement("context-menu", ParentTag = "kendo-filemanager", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("items", new string[] {})]
  [SuppressTagRendering]
  public class FileManagerContextMenuSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FileManagerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FileManagerTagHelper).ContextMenu = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerContextMenuSettingsItemsTagHelper Items { get; set; }

    public string Close { get; set; }

    public string Open { get; set; }

    public string Activate { get; set; }

    public string Deactivate { get; set; }

    public string Select { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<FileManagerContextMenuSettingsItemTagHelper, Dictionary<string, object>>((Func<FileManagerContextMenuSettingsItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      string close = this.Close;
      if ((close != null ? (close.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.Close);
      string open = this.Open;
      if ((open != null ? (open.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.Open);
      string activate = this.Activate;
      if ((activate != null ? (activate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activate"] = (object) this.CreateHandler(this.Activate);
      string deactivate = this.Deactivate;
      if ((deactivate != null ? (deactivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deactivate"] = (object) this.CreateHandler(this.Deactivate);
      string select = this.Select;
      if ((select != null ? (select.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.Select);
      return dictionary;
    }
  }
}
