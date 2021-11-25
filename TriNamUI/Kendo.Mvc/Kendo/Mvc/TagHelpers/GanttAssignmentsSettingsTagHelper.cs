// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GanttAssignmentsSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("assignments", ParentTag = "kendo-gantt", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("datasource", new string[] {})]
  [SuppressTagRendering]
  public class GanttAssignmentsSettingsTagHelper : 
    TagHelperChildBase,
    IDataBoundWidget<
    #nullable disable
    DataSourceTagHelper>
  {
    [HtmlAttributeName("dataresourceidfield")]
    public string DataResourceIdField { get; set; }

    [HtmlAttributeName("datataskidfield")]
    public string DataTaskIdField { get; set; }

    [HtmlAttributeName("datavaluefield")]
    public string DataValueField { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceTagHelper Datasource { get; set; }

    public string DatasourceId { get; set; }

    public IEnumerable<object> BindTo { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GanttTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GanttTagHelper).Assignments = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string dataResourceIdField = this.DataResourceIdField;
      if ((dataResourceIdField != null ? (dataResourceIdField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataResourceIdField"] = (object) this.DataResourceIdField;
      string dataTaskIdField = this.DataTaskIdField;
      if ((dataTaskIdField != null ? (dataTaskIdField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTaskIdField"] = (object) this.DataTaskIdField;
      string dataValueField = this.DataValueField;
      if ((dataValueField != null ? (dataValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataValueField"] = (object) this.DataValueField;
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      else if (this.BindTo != null)
        dictionary["dataSource"] = (object) this.BindTo;
      return dictionary;
    }

    internal Dictionary<string, object> SerializeSettings() => new Dictionary<string, object>();
  }
}
