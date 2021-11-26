// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.AppBarTagHelper
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
  [HtmlTargetElement("kendo-appbar")]
  [RestrictChildren("items", new string[] {})]
  public class AppBarTagHelper : TagHelperBase
  {
    public AppBarTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      AppBarTagHelper appBarTagHelper = this;
      context.Items[(object) appBarTagHelper.GetType()] = (object) appBarTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await appBarTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "AppBar", (IDictionary<string, object>) this.SerializeSettings());

    public string OnResize { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onResize = this.OnResize;
      if ((onResize != null ? (onResize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resize"] = (object) this.CreateHandler(this.OnResize);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public AppBarItemsTagHelper Items { get; set; }

    public AppBarPosition? Position { get; set; }

    public AppBarPositionMode? PositionMode { get; set; }

    public AppBarThemeColor? ThemeColor { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<AppBarItemTagHelper, Dictionary<string, object>>((Func<AppBarItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["items"] = (object) source;
      }
      if (this.Position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        AppBarPosition? position = this.Position;
        ref AppBarPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      if (this.PositionMode.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        AppBarPositionMode? positionMode = this.PositionMode;
        ref AppBarPositionMode? local = ref positionMode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["positionMode"] = (object) str;
      }
      if (this.ThemeColor.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        AppBarThemeColor? themeColor = this.ThemeColor;
        ref AppBarThemeColor? local = ref themeColor;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["themeColor"] = (object) str;
      }
      return dictionary1;
    }
  }
}
