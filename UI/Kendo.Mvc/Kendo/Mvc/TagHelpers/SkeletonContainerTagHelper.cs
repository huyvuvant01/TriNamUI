// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SkeletonContainerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
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
  [HtmlTargetElement("kendo-skeletoncontainer")]
  [RestrictChildren("grid", new string[] {})]
  public class SkeletonContainerTagHelper : TagHelperBase
  {
    public SkeletonContainerTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      SkeletonContainerTagHelper containerTagHelper = this;
      context.Items[(object) containerTagHelper.GetType()] = (object) containerTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await containerTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "SkeletonContainer", (IDictionary<string, object>) this.SerializeSettings());

    protected override Dictionary<string, object> SerializeEvents() => new Dictionary<string, object>();

    [HtmlAttributeNotBound]
    public SkeletonContainerGridSettingsTagHelper Grid { get; set; }

    public string Height { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Width { get; set; }

    public SkeletonContainerAnimation? Animation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Grid != null)
      {
        Dictionary<string, object> source = this.Grid.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["grid"] = (object) source;
      }
      string height = this.Height;
      if ((height != null ? (height.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["height"] = (object) this.Height;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["width"] = (object) this.Width;
      if (this.Animation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        SkeletonContainerAnimation? animation = this.Animation;
        ref SkeletonContainerAnimation? local = ref animation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["animation"] = (object) str;
      }
      return dictionary1;
    }
  }
}
