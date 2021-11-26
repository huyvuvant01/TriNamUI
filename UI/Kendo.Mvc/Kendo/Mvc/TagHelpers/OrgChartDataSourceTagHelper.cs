// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.OrgChartDataSourceTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-orgchartdatasource")]
  [HtmlTargetElement("orgchart-datasource", ParentTag = "kendo-orgchart")]
  [RestrictChildren("filters", new string[] {"schema", "sorts", "transport"})]
  public class OrgChartDataSourceTagHelper : DataSourceTagHelper
  {
    public OrgChartDataSourceSchemaSettingsTagHelper Schema { get; set; }

    public OrgChartDataSourceTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    protected override void SetDataSource(object item)
    {
      if (!(item is IDataBoundWidget<OrgChartDataSourceTagHelper>))
        return;
      (item as IDataBoundWidget<OrgChartDataSourceTagHelper>).Datasource = this;
      this.IsNested = true;
    }

    protected override void AddSelfToContext(TagHelperContext context) => context.Items[(object) typeof (DataSourceTagHelper)] = (object) this;

    protected override string GetInitializationScript() => this.Name + " = new kendo.data.OrgChartDataSource(" + this.Initializer.Serialize((IDictionary<string, object>) this.Serialize()) + ");";

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
