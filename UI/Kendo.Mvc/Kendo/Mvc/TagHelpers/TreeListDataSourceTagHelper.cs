// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListDataSourceTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-treelistdatasource")]
  [HtmlTargetElement("treelist-datasource", ParentTag = "kendo-treelist")]
  [RestrictChildren("aggregates", new string[] {"filters", "groups", "schema", "sorts", "transport"})]
  public class TreeListDataSourceTagHelper : DataSourceTagHelper
  {
    public TreeListDataSourceSchemaSettingsTagHelper Schema { get; set; }

    public TreeListDataSourceTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    protected override void SetDataSource(object item)
    {
      if (!(item is IDataBoundWidget<TreeListDataSourceTagHelper>))
        return;
      (item as IDataBoundWidget<TreeListDataSourceTagHelper>).Datasource = this;
      this.IsNested = true;
    }

    protected override void AddSelfToContext(TagHelperContext context) => context.Items[(object) typeof (DataSourceTagHelper)] = (object) this;

    protected override string GetInitializationScript() => this.Name + " = new kendo.data.TreeListDataSource(" + this.Initializer.Serialize((IDictionary<string, object>) this.Serialize()) + ");";

    internal override Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = base.Serialize();
      if (this.Schema != null)
      {
        Dictionary<string, object> source = this.Schema?.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["schema"] = (object) source;
      }
      return dictionary;
    }
  }
}
