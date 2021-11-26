// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ButtonGroupItemTagHelper
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
  [HtmlTargetElement("item", ParentTag = "buttongroup-items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class ButtonGroupItemTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ButtonGroupItemsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ButtonGroupItemsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public IDictionary<string, object> HtmlAttributes { get; set; }

    [HtmlAttributeNotBound]
    public ButtonGroupItemBadgeSettingsTagHelper Badge { get; set; }

    public bool? Enabled { get; set; }

    public string Icon { get; set; }

    public string IconClass { get; set; }

    public string ImageUrl { get; set; }

    public bool? Selected { get; set; }

    public string Text { get; set; }

    public bool? Encoded { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.HtmlAttributes;
      if (this.Badge != null)
      {
        Dictionary<string, object> source = this.Badge.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Badge.Enabled.HasValue || this.Badge.Enabled.Value))
          dictionary["badge"] = (object) source;
        else if (this.Badge.Enabled.HasValue && !this.Badge.Enabled.Value)
          dictionary["badge"] = (object) this.Badge.Enabled;
      }
      bool? nullable = this.Enabled;
      if (nullable.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["icon"] = (object) this.Icon;
      string iconClass = this.IconClass;
      if ((iconClass != null ? (iconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["iconClass"] = (object) this.IconClass;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageUrl"] = (object) this.ImageUrl;
      nullable = this.Selected;
      if (nullable.HasValue)
        dictionary["selected"] = (object) this.Selected;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      nullable = this.Encoded;
      if (nullable.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      return dictionary;
    }
  }
}
