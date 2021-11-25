// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropDownTreeItemTagHelper
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
  [HtmlTargetElement("dropdowntree-item", ParentTag = "items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("items", new string[] {})]
  [SuppressTagRendering]
  public class DropDownTreeItemTagHelper : TagHelperCollectionItemBase
  {
    private 
    #nullable disable
    DropDownTreeItemTagHelper PreviousInstance { get; set; }

    [HtmlAttributeNotBound]
    public DropDownTreeNestedItemsTagHelper Items { get; set; }

    public string Id { get; set; }

    public string Text { get; set; }

    public string Value { get; set; }

    public string Url { get; set; }

    public string ImageUrl { get; set; }

    public string SpriteCssClass { get; set; }

    public bool? Enabled { get; set; }

    public bool? Checked { get; set; }

    public bool? Selected { get; set; }

    public bool? HasChildren { get; set; }

    public bool? Encoded { get; set; }

    public IDictionary<string, string> HtmlAttributes { get; set; }

    public bool? Expanded { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DropDownTreeItemTagHelper treeItemTagHelper = this;
      Type type = treeItemTagHelper.GetType();
      if (context.Items.ContainsKey((object) type))
        treeItemTagHelper.PreviousInstance = context.Items[(object) type] as DropDownTreeItemTagHelper;
      context.Items[(object) type] = (object) treeItemTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      treeItemTagHelper.AddSelfToParent(context);
      context.Items[(object) type] = (object) treeItemTagHelper.PreviousInstance;
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type1 = typeof (DropDownTreeNestedItemsTagHelper);
      if (context.Items.ContainsKey((object) type1))
      {
        (context.Items[(object) type1] as DropDownTreeNestedItemsTagHelper).Add(this);
      }
      else
      {
        Type type2 = typeof (DropDownTreeItemsTagHelper);
        (context.Items[(object) type2] as DropDownTreeItemsTagHelper).Add(this);
      }
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["id"] = (object) this.Id;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      string str = this.Value;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["value"] = (object) this.Value;
      string url = this.Url;
      if ((url != null ? (url.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["url"] = (object) this.Url;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageUrl"] = (object) this.ImageUrl;
      string spriteCssClass = this.SpriteCssClass;
      if ((spriteCssClass != null ? (spriteCssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["spriteCssClass"] = (object) this.SpriteCssClass;
      bool? nullable = this.Enabled;
      if (nullable.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      IDictionary<string, string> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, string>>() ? 1 : 0) : 0) != 0)
        dictionary["attr"] = (object) this.HtmlAttributes;
      nullable = this.Checked;
      if (nullable.HasValue)
        dictionary["checked"] = (object) this.Checked;
      nullable = this.Selected;
      if (nullable.HasValue)
        dictionary["selected"] = (object) this.Selected;
      nullable = this.HasChildren;
      if (nullable.HasValue)
        dictionary["hasChildren"] = (object) this.HasChildren;
      nullable = this.Encoded;
      if (nullable.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      nullable = this.Expanded;
      if (nullable.HasValue)
        dictionary["expanded"] = (object) this.Expanded;
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<DropDownTreeItemTagHelper, Dictionary<string, object>>((Func<DropDownTreeItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      return dictionary;
    }
  }
}
