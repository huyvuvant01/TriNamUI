// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeViewItemBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.TagHelpers
{
  public class TreeViewItemBase
  {
    public string Id { get; set; }

    public string Text { get; set; }

    public string Url { get; set; }

    public string ImageUrl { get; set; }

    public string SpriteCssClass { get; set; }

    public bool? Enabled { get; set; }

    public bool? Checked { get; set; }

    public bool? Selected { get; set; }

    public bool? Expanded { get; set; }

    public bool? HasChildren { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public IEnumerable<TreeViewItemBase> Items { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["id"] = (object) this.Id;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
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
      nullable = this.Checked;
      if (nullable.HasValue)
        dictionary["checked"] = (object) this.Checked;
      nullable = this.Selected;
      if (nullable.HasValue)
        dictionary["selected"] = (object) this.Selected;
      nullable = this.Expanded;
      if (nullable.HasValue)
        dictionary["expanded"] = (object) this.Expanded;
      nullable = this.HasChildren;
      if (nullable.HasValue)
        dictionary["hasChildren"] = (object) this.HasChildren;
      if (this.HtmlAttributes != null && this.HtmlAttributes.Any<KeyValuePair<string, object>>())
        dictionary["attr"] = (object) this.HtmlAttributes;
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<TreeViewItemBase, Dictionary<string, object>>((Func<TreeViewItemBase, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      return dictionary;
    }
  }
}
