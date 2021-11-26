// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.LoaderTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-loader")]
  public class LoaderTagHelper : TagHelperBase
  {
    public LoaderTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      LoaderTagHelper loaderTagHelper = this;
      context.Items[(object) loaderTagHelper.GetType()] = (object) loaderTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await loaderTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Loader", (IDictionary<string, object>) this.SerializeSettings());

    protected override Dictionary<string, object> SerializeEvents() => new Dictionary<string, object>();

    [HtmlAttributeNotBound]
    public LoaderMessagesSettingsTagHelper Messages { get; set; }

    public bool? Visible { get; set; }

    public LoaderSize? Size { get; set; }

    public LoaderThemeColor? ThemeColor { get; set; }

    public LoaderType? Type { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["messages"] = (object) source;
      }
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      if (this.Size.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        LoaderSize? size = this.Size;
        ref LoaderSize? local = ref size;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["size"] = (object) str;
      }
      if (this.ThemeColor.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        LoaderThemeColor? themeColor = this.ThemeColor;
        ref LoaderThemeColor? local = ref themeColor;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["themeColor"] = (object) str;
      }
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        LoaderType? type = this.Type;
        ref LoaderType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
