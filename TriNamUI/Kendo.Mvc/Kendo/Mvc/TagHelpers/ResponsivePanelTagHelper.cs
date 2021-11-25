// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ResponsivePanelTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-responsivepanel")]
  public class ResponsivePanelTagHelper : TagHelperBase
  {
    public ResponsivePanelTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public string Orientation { get; set; }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string orientation = this.Orientation;
      if ((orientation != null ? (orientation.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["orientation"] = (object) this.Orientation;
      return this.Initializer.Initialize(this.Selector, "ResponsivePanel", (IDictionary<string, object>) dictionary);
    }

    public string OnClose { get; set; }

    public string OnOpen { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onClose = this.OnClose;
      if ((onClose != null ? (onClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.OnClose);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      return dictionary;
    }

    public bool? AutoClose { get; set; }

    public double? Breakpoint { get; set; }

    public string ToggleButton { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoClose.HasValue)
        dictionary["autoClose"] = (object) this.AutoClose;
      if (this.Breakpoint.HasValue)
        dictionary["breakpoint"] = (object) this.Breakpoint;
      string toggleButton = this.ToggleButton;
      if ((toggleButton != null ? (toggleButton.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggleButton"] = (object) this.ToggleButton;
      return dictionary;
    }
  }
}
