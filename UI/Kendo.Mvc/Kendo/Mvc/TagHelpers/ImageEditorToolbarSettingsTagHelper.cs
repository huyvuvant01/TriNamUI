// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ImageEditorToolbarSettingsTagHelper
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
  [HtmlTargetElement("toolbar", ParentTag = "kendo-imageeditor", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("items", new string[] {})]
  [SuppressTagRendering]
  public class ImageEditorToolbarSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ImageEditorTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ImageEditorTagHelper).Toolbar = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    [HtmlAttributeNotBound]
    public ImageEditorToolbarSettingsItemsTagHelper Items { get; set; }

    public string Click { get; set; }

    public string Close { get; set; }

    public string Open { get; set; }

    public string Toggle { get; set; }

    public string OverflowClose { get; set; }

    public string OverflowOpen { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<ImageEditorToolbarSettingsItemTagHelper, Dictionary<string, object>>((Func<ImageEditorToolbarSettingsItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      string click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.CreateHandler(this.Click);
      string close = this.Close;
      if ((close != null ? (close.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.Close);
      string open = this.Open;
      if ((open != null ? (open.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.Open);
      string toggle = this.Toggle;
      if ((toggle != null ? (toggle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggle"] = (object) this.CreateHandler(this.Toggle);
      string overflowClose = this.OverflowClose;
      if ((overflowClose != null ? (overflowClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["overflowClose"] = (object) this.CreateHandler(this.OverflowClose);
      string overflowOpen = this.OverflowOpen;
      if ((overflowOpen != null ? (overflowOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["overflowOpen"] = (object) this.CreateHandler(this.OverflowOpen);
      return dictionary;
    }
  }
}
