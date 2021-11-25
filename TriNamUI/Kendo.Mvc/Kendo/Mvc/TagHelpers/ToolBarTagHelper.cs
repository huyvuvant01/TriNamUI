// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ToolBarTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-toolbar")]
  [RestrictChildren("toolbar-items", new string[] {})]
  [OutputElementHint("div")]
  public class ToolBarTagHelper : TagHelperBase
  {
    public ToolBarTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ToolBarTagHelper toolBarTagHelper = this;
      context.Items[(object) toolBarTagHelper.GetType()] = (object) toolBarTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await toolBarTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "ToolBar", (IDictionary<string, object>) this.SerializeSettings());

    public string OnClick { get; set; }

    public string OnClose { get; set; }

    public string OnOpen { get; set; }

    public string OnToggle { get; set; }

    public string OnOverflowClose { get; set; }

    public string OnOverflowOpen { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onClick = this.OnClick;
      if ((onClick != null ? (onClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.CreateHandler(this.OnClick);
      string onClose = this.OnClose;
      if ((onClose != null ? (onClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.OnClose);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      string onToggle = this.OnToggle;
      if ((onToggle != null ? (onToggle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggle"] = (object) this.CreateHandler(this.OnToggle);
      string onOverflowClose = this.OnOverflowClose;
      if ((onOverflowClose != null ? (onOverflowClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["overflowClose"] = (object) this.CreateHandler(this.OnOverflowClose);
      string onOverflowOpen = this.OnOverflowOpen;
      if ((onOverflowOpen != null ? (onOverflowOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["overflowOpen"] = (object) this.CreateHandler(this.OnOverflowOpen);
      return dictionary;
    }

    public bool? Resizable { get; set; }

    [HtmlAttributeNotBound]
    public ToolBarItemsTagHelper Items { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Resizable.HasValue)
        dictionary["resizable"] = (object) this.Resizable;
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<ToolBarItemTagHelper, Dictionary<string, object>>((Func<ToolBarItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      return dictionary;
    }
  }
}
