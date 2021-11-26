// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropDownTreeItemBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Reflection;

namespace Kendo.Mvc.TagHelpers
{
  public class DropDownTreeItemBase
  {
    public string Text { get; set; }

    public string Value { get; set; }

    public string Url { get; set; }

    public string ImageUrl { get; set; }

    public string IconClass { get; set; }

    public bool? Enabled { get; set; }

    public bool? Selected { get; set; }

    public bool? Expanded { get; set; }

    public bool? Encoded { get; set; }

    public bool? HasChildren { get; set; }

    public IDictionary<string, string> HtmlAttributes { get; set; }

    public string ContentUrl { get; set; }

    public IEnumerable<DropDownTreeItemBase> Items { get; set; }

    public DropDownTreeItemTagHelper ConvertToTagHelper()
    {
      DropDownTreeItemTagHelper treeItemTagHelper = new DropDownTreeItemTagHelper();
      foreach (PropertyInfo property in typeof (DropDownTreeItemBase).GetProperties())
        typeof (DropDownTreeItemTagHelper).GetProperty(property.Name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public).SetValue((object) treeItemTagHelper, property.GetValue((object) this));
      return treeItemTagHelper;
    }
  }
}
