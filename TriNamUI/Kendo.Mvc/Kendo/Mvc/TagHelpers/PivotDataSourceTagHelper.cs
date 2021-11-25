// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-pivotdatasource")]
  [HtmlTargetElement("pivot-datasource", ParentTag = "kendo-pivotgrid")]
  [HtmlTargetElement("pivot-datasource", ParentTag = "kendo-pivotconfigurator")]
  [RestrictChildren("columns", new string[] {"rows", "measures", "schema", "transport"})]
  public class PivotDataSourceTagHelper : DataSourceTagHelper
  {
    public PivotDataSourceTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    protected override void SetDataSource(object item)
    {
      if (!(item is IDataBoundWidget<PivotDataSourceTagHelper>))
        return;
      (item as IDataBoundWidget<PivotDataSourceTagHelper>).Datasource = this;
      this.IsNested = true;
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void WriteHtml(TagHelperOutput output) => output.SuppressOutput();

    protected override string GetInitializationScript() => this.Name + " = new kendo.data.PivotDataSource(" + this.Initializer.Serialize((IDictionary<string, object>) this.Serialize()) + ");";

    internal override Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = base.Serialize();
      if (this.Transport != null)
      {
        Dictionary<string, object> source = this.Transport.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["transport"] = (object) source;
      }
      if (this.Schema != null)
      {
        Dictionary<string, object> source = this.Schema.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["schema"] = (object) source;
      }
      if (this.Columns != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Columns.Select<PivotDataSourceColumnTagHelper, Dictionary<string, object>>((Func<PivotDataSourceColumnTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["columns"] = (object) source;
      }
      if (this.Rows != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Rows.Select<PivotDataSourceRowTagHelper, Dictionary<string, object>>((Func<PivotDataSourceRowTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["rows"] = (object) source;
      }
      if (this.Measures != null)
      {
        Dictionary<string, object> source = this.Measures.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["measures"] = (object) source;
      }
      if (this.Type.HasValue)
        dictionary["type"] = (object) this.Type;
      return dictionary;
    }

    private string GenerateTypeFunction(bool isAspNetMvc)
    {
      string format = "(function(){{if(kendo.data.transports['{0}{1}']){{return '{0}{1}';}} else{{throw new Error('The kendo.aspnetmvc.min.js script is not included.');}}}})()";
      return isAspNetMvc ? string.Format(format, (object) "aspnetmvc-", (object) this.Type.ToString().ToLower()) : string.Format(format, (object) "", (object) this.Type.ToString().ToLower());
    }

    public PivotDataSourceRowsTagHelperCollection Rows { get; set; }

    public PivotDataSourceColumnsTagHelperCollection Columns { get; set; }

    public PivotDataSourceTransportSettingsTagHelper Transport { get; set; }

    public PivotDataSourceSchemaSettingsTagHelper Schema { get; set; }

    public PivotDataSourceMeasuresSettingsTagHelper Measures { get; set; }

    public PivotDataSourceType? Type { get; set; }
  }
}
