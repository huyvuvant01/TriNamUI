// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GanttResourcesSettingsTagHelper
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
  [HtmlTargetElement("resources", ParentTag = "kendo-gantt", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("datasource", new string[] {})]
  [SuppressTagRendering]
  public class GanttResourcesSettingsTagHelper : 
    TagHelperChildBase,
    IDataBoundWidget<
    #nullable disable
    DataSourceTagHelper>
  {
    [HtmlAttributeName("dataformatfield")]
    public string DataFormatField { get; set; }

    [HtmlAttributeName("datacolorfield")]
    public string DataColorField { get; set; }

    [HtmlAttributeName("datatextfield")]
    public string DataTextField { get; set; }

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
      (context.Items[(object) type] as GanttTagHelper).Resources = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string dataFormatField = this.DataFormatField;
      if ((dataFormatField != null ? (dataFormatField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataFormatField"] = (object) this.DataFormatField;
      string dataColorField = this.DataColorField;
      if ((dataColorField != null ? (dataColorField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataColorField"] = (object) this.DataColorField;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      else if (this.BindTo != null)
        dictionary["dataSource"] = (object) this.BindTo;
      return dictionary;
    }

    public string Field { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      return dictionary;
    }
  }
}
