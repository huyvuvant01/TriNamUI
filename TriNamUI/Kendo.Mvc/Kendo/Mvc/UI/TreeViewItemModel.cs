// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeViewItemModel
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class TreeViewItemModel : IHierarchicalItem
  {
    public TreeViewItemModel()
    {
      this.Enabled = true;
      this.Encoded = true;
      this.Items = new List<TreeViewItemModel>();
      this.HtmlAttributes = (IDictionary<string, string>) new Dictionary<string, string>();
      this.ImageHtmlAttributes = (IDictionary<string, string>) new Dictionary<string, string>();
      this.LinkHtmlAttributes = (IDictionary<string, string>) new Dictionary<string, string>();
    }

    public bool Enabled { get; set; }

    public bool Expanded { get; set; }

    public bool Encoded { get; set; }

    public bool Selected { get; set; }

    public string Text { get; set; }

    public string SpriteCssClass { get; set; }

    public string Id { get; set; }

    public string Url { get; set; }

    public string ImageUrl { get; set; }

    public bool HasChildren { get; set; }

    public bool Checked { get; set; }

    public List<TreeViewItemModel> Items { get; set; }

    public IDictionary<string, string> HtmlAttributes { get; set; }

    public IDictionary<string, string> ImageHtmlAttributes { get; set; }

    public IDictionary<string, string> LinkHtmlAttributes { get; set; }
  }
}
