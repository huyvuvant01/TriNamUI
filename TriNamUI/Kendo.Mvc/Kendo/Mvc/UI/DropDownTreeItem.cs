// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DropDownTreeItem
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DropDownTreeItem : 
    NavigationItem<DropDownTreeItem>,
    INavigationItemContainer<DropDownTreeItem>,
    IHierarchicalItem
  {
    public DropDownTreeItem() => this.Items = (IList<DropDownTreeItem>) new LinkedObjectCollection<DropDownTreeItem>(this);

    public virtual IList<DropDownTreeItem> Items { get; private set; }

    public string Id { get; set; }

    public bool Expanded { get; set; }

    public bool HasChildren { get; set; }

    public bool Checked { get; set; }

    public string Value { get; set; }

    private void Serialize<T>(
      IDictionary<string, object> json,
      string field,
      T value,
      T defaultValue)
      where T : IComparable<T>
    {
      if (((object) value != null || (object) defaultValue == null) && ((object) value == null || value.CompareTo(defaultValue) == 0))
        return;
      json[field] = (object) value;
    }

    private string ConvertUrl(string url, IUrlHelper urlHelper) => urlHelper == null || string.IsNullOrEmpty(url) ? url : urlHelper.Content(url);

    public virtual IDictionary<string, object> Serialize(IUrlHelper urlHelper)
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      dictionary["id"] = (object) this.Id;
      dictionary["text"] = (object) this.Text;
      dictionary["value"] = (object) this.Value;
      this.Serialize<bool>((IDictionary<string, object>) dictionary, "hasChildren", this.HasChildren, false);
      this.Serialize<bool>((IDictionary<string, object>) dictionary, "encoded", this.Encoded, true);
      this.Serialize<bool>((IDictionary<string, object>) dictionary, "expanded", this.Expanded, false);
      this.Serialize<bool>((IDictionary<string, object>) dictionary, "checked", this.Checked, false);
      this.Serialize<bool>((IDictionary<string, object>) dictionary, "selected", this.Selected, false);
      this.Serialize<string>((IDictionary<string, object>) dictionary, "imageUrl", this.ConvertUrl(this.ImageUrl, urlHelper), (string) null);
      this.Serialize<string>((IDictionary<string, object>) dictionary, "url", this.ConvertUrl(this.Url, urlHelper), (string) null);
      this.Serialize<string>((IDictionary<string, object>) dictionary, "spriteCssClass", this.SpriteCssClasses, (string) null);
      this.Serialize<bool>((IDictionary<string, object>) dictionary, "enabled", this.Enabled, true);
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attr"] = (object) this.HtmlAttributes;
      if (this.Items.Count > 0)
        dictionary["items"] = (object) this.Items.Select<DropDownTreeItem, IDictionary<string, object>>((Func<DropDownTreeItem, IDictionary<string, object>>) (item => item.Serialize(urlHelper)));
      return (IDictionary<string, object>) dictionary;
    }
  }
}
