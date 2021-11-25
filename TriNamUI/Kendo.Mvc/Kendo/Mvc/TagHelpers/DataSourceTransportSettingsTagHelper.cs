// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceTransportSettingsTagHelper
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
  [HtmlTargetElement("transport", ParentTag = "kendo-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "kendo-treelistdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "treelist-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "kendo-hierarchicaldatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "hierarchical-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "kendo-schedulerdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "scheduler-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "gantt-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "kendo-ganttdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "dependency-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "kendo-ganttdependencydatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "kendo-filemanagerdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "filemanager-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("transport", ParentTag = "orgchart-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("create", new string[] {"destroy", "read", "update"})]
  [SuppressTagRendering]
  public class DataSourceTransportSettingsTagHelper : TagHelperChildBase
  {
    public bool? Cache { get; set; }

    [HtmlAttributeNotBound]
    public 
    #nullable disable
    DatasourceTransportDestroySettingsTagHelper Destroy { get; set; }

    public string ParameterMap { get; set; }

    internal string IdField { get; set; }

    [HtmlAttributeNotBound]
    public DatasourceTransportReadSettingsTagHelper Read { get; set; }

    public string Submit { get; set; }

    [HtmlAttributeNotBound]
    public DatasourceTransportUpdateSettingsTagHelper Update { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceTransportCreateSettingsTagHelper Create { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      if (this.AddToParent(context, typeof (DataSourceTagHelper)))
        return;
      this.AddToParent(context, typeof (GridColumnFilterDataSourceTagHelper));
    }

    internal virtual Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Cache.HasValue)
        dictionary["cache"] = (object) this.Cache;
      if (this.Destroy != null)
      {
        Dictionary<string, object> source = this.Destroy.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["destroy"] = (object) source;
      }
      string parameterMap = this.ParameterMap;
      if ((parameterMap != null ? (parameterMap.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["parameterMap"] = (object) this.CreateHandler(this.ParameterMap);
      if (this.Read != null)
      {
        Dictionary<string, object> source = this.Read.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["read"] = (object) source;
      }
      string submit = this.Submit;
      if ((submit != null ? (submit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["submit"] = (object) this.CreateHandler(this.Submit);
      if (this.Update != null)
      {
        Dictionary<string, object> source = this.Update.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["update"] = (object) source;
      }
      if (this.Create != null)
      {
        Dictionary<string, object> source = this.Create.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["create"] = (object) source;
      }
      if (this.IdField.HasValue())
        dictionary["idField"] = (object) this.IdField;
      return dictionary;
    }

    private bool AddToParent(TagHelperContext context, Type DataSourceType)
    {
      if (!context.Items.ContainsKey((object) DataSourceType))
        return false;
      (context.Items[(object) DataSourceType] as DataSourceTagHelper).Transport = this;
      return true;
    }
  }
}
