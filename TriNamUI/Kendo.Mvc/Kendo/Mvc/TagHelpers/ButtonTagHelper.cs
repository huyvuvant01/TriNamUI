// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ButtonTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-button")]
  [OutputElementHint("button")]
  public class ButtonTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    string Tag { get; set; }

    public ButtonTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
      this.Tag = "button";
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ButtonTagHelper buttonTagHelper = this;
      context.Items[(object) buttonTagHelper.GetType()] = (object) buttonTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await buttonTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag(this.Tag, this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>()
      {
        {
          "type",
          (object) "button"
        }
      });
      output.TagName = this.Tag;
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Button", (IDictionary<string, object>) this.SerializeSettings());

    public string OnClick { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onClick = this.OnClick;
      if ((onClick != null ? (onClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.CreateHandler(this.OnClick);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public ButtonBadgeSettingsTagHelper Badge { get; set; }

    public bool? Enable { get; set; }

    public string Icon { get; set; }

    public string IconClass { get; set; }

    public string ImageUrl { get; set; }

    public string SpriteCssClass { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Badge != null)
      {
        Dictionary<string, object> source = this.Badge.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Badge.Enabled.HasValue || this.Badge.Enabled.Value))
          dictionary["badge"] = (object) source;
        else if (this.Badge.Enabled.HasValue && !this.Badge.Enabled.Value)
          dictionary["badge"] = (object) this.Badge.Enabled;
      }
      if (this.Enable.HasValue)
        dictionary["enable"] = (object) this.Enable;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["icon"] = (object) this.Icon;
      string iconClass = this.IconClass;
      if ((iconClass != null ? (iconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["iconClass"] = (object) this.IconClass;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageUrl"] = (object) this.ImageUrl;
      string spriteCssClass = this.SpriteCssClass;
      if ((spriteCssClass != null ? (spriteCssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["spriteCssClass"] = (object) this.SpriteCssClass;
      return dictionary;
    }
  }
}
