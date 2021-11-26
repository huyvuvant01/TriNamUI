// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnMenuColumnsSettingsTagHelper
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
  [HtmlTargetElement("column-menu-columns", ParentTag = "column-menu", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class GridColumnMenuColumnsSettingsTagHelper : TagHelperChildBase
  {
    public GridColumnMenuColumnsSettingsTagHelper() => this.Groups = new GridColumnMenuColumnsGroupsTagHelper();

    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridColumnMenuSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridColumnMenuSettingsTagHelper).Columns = this;
    }

    public GridColumnMenuColumnsGroupsTagHelper Groups { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Groups != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Groups.Select<GridColumnMenuColumnsGroupTagHelper, Dictionary<string, object>>((Func<GridColumnMenuColumnsGroupTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["groups"] = (object) source;
      }
      return dictionary;
    }

    public bool? Enabled { get; set; }

    public string Sort { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string sort = this.Sort;
      if ((sort != null ? (sort.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sort"] = (object) this.Sort;
      return dictionary;
    }
  }
}
