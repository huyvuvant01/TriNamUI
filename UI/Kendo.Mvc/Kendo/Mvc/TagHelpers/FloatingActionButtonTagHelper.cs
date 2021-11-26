// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FloatingActionButtonTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
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
  [HtmlTargetElement("kendo-floatingactionbutton")]
  [RestrictChildren("floatingactionbutton-items", new string[] {})]
  public class FloatingActionButtonTagHelper : TagHelperBase
  {
    public FloatingActionButtonTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    [HtmlAttributeName("align-offset-horizontal")]
    public string AlignOffsetHorizontal { get; set; }

    [HtmlAttributeName("align-offset-vertical")]
    public string AlignOffsetVertical { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      FloatingActionButtonTagHelper actionButtonTagHelper = this;
      context.Items[(object) actionButtonTagHelper.GetType()] = (object) actionButtonTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await actionButtonTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("button", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "button";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
      if (this.AlignOffsetHorizontal.HasValue())
        dictionary2["x"] = (object) this.AlignOffsetHorizontal;
      if (this.AlignOffsetHorizontal.HasValue())
        dictionary2["y"] = (object) this.AlignOffsetVertical;
      dictionary1["alignOffset"] = (object) dictionary2;
      return this.Initializer.Initialize(this.Selector, "FloatingActionButton", (IDictionary<string, object>) dictionary1);
    }

    public string OnClick { get; set; }

    public string OnCollapse { get; set; }

    public string OnExpand { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onClick = this.OnClick;
      if ((onClick != null ? (onClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.CreateHandler(this.OnClick);
      string onCollapse = this.OnCollapse;
      if ((onCollapse != null ? (onCollapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapse"] = (object) this.CreateHandler(this.OnCollapse);
      string onExpand = this.OnExpand;
      if ((onExpand != null ? (onExpand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expand"] = (object) this.CreateHandler(this.OnExpand);
      return dictionary;
    }

    public bool? Enabled { get; set; }

    public string Icon { get; set; }

    [HtmlAttributeNotBound]
    public FloatingActionButtonItemsTagHelper Items { get; set; }

    public string Text { get; set; }

    public bool? Visible { get; set; }

    public FloatingActionButtonSize? Size { get; set; }

    public FloatingActionButtonAlign? Align { get; set; }

    public FloatingActionButtonPositionMode? PositionMode { get; set; }

    public FloatingActionButtonShape? Shape { get; set; }

    public FloatingActionButtonThemeColor? ThemeColor { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Enabled.HasValue)
        dictionary1["enabled"] = (object) this.Enabled;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["icon"] = (object) this.Icon;
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<FloatingActionButtonItemTagHelper, Dictionary<string, object>>((Func<FloatingActionButtonItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["items"] = (object) source;
      }
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      if (this.Size.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        FloatingActionButtonSize? size = this.Size;
        ref FloatingActionButtonSize? local = ref size;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["size"] = (object) str;
      }
      if (this.Align.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        FloatingActionButtonAlign? align = this.Align;
        ref FloatingActionButtonAlign? local = ref align;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["align"] = (object) str;
      }
      if (this.PositionMode.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        FloatingActionButtonPositionMode? positionMode = this.PositionMode;
        ref FloatingActionButtonPositionMode? local = ref positionMode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["positionMode"] = (object) str;
      }
      if (this.Shape.HasValue)
      {
        Dictionary<string, object> dictionary5 = dictionary1;
        FloatingActionButtonShape? shape = this.Shape;
        ref FloatingActionButtonShape? local = ref shape;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary5["shape"] = (object) str;
      }
      if (this.ThemeColor.HasValue)
      {
        Dictionary<string, object> dictionary6 = dictionary1;
        FloatingActionButtonThemeColor? themeColor = this.ThemeColor;
        ref FloatingActionButtonThemeColor? local = ref themeColor;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary6["themeColor"] = (object) str;
      }
      return dictionary1;
    }
  }
}
