// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnMenuColumnsGroupTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("column-menu-columns-group", ParentTag = "column-menu-columns-groups", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class GridColumnMenuColumnsGroupTagHelper : TagHelperCollectionItemBase
  {
    public GridColumnMenuColumnsGroupTagHelper() => this.Columns = (IEnumerable<string>) new List<string>();

    private GridColumnTagHelper PreviousInstance { get; set; }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridColumnMenuColumnsGroupsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridColumnMenuColumnsGroupsTagHelper).Add(this);
    }

    public string Title { get; set; }

    public IEnumerable<string> Columns { get; set; }

    internal virtual Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Title.Any<char>())
        dictionary["title"] = (object) this.Title;
      if (this.Columns.Any<string>())
        dictionary["columns"] = (object) this.Columns;
      return dictionary;
    }
  }
}
