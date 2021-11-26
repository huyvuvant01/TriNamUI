// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceSchemaSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("schema", ParentTag = "kendo-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("schema", ParentTag = "datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("schema", ParentTag = "gantt-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("schema", ParentTag = "kendo-ganttdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("schema", ParentTag = "dependency-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("schema", ParentTag = "kendo-ganttdependencydatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("model", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceSchemaSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Aggregates { get; set; }

    public string AggregatesHandler { get; set; }

    public string Data { get; set; }

    public string Datahandler { get; set; }

    public string Errors { get; set; }

    public string ErrorsHandler { get; set; }

    public string Groups { get; set; }

    public string GroupsHandler { get; set; }

    public string Parse { get; set; }

    public string Total { get; set; }

    public string TotalHandler { get; set; }

    public string Type { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceSchemaModelSettingsTagHelper Model { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (DataSourceTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceTagHelper).Schema = this;
    }

    internal virtual Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string parse = this.Parse;
      if ((parse != null ? (parse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["parse"] = (object) this.CreateHandler(this.Parse);
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      if (this.Model != null)
      {
        Dictionary<string, object> source = this.Model.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["model"] = (object) source;
      }
      string aggregatesHandler = this.AggregatesHandler;
      if ((aggregatesHandler != null ? (aggregatesHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["aggregates"] = (object) this.CreateHandler(this.AggregatesHandler);
      else if (this.Aggregates.HasValue())
        dictionary["aggregates"] = (object) this.Aggregates;
      string datahandler = this.Datahandler;
      if ((datahandler != null ? (datahandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["data"] = (object) this.CreateHandler(this.Datahandler);
      else if (this.Data.HasValue())
        dictionary["data"] = (object) this.Data;
      string errorsHandler = this.ErrorsHandler;
      if ((errorsHandler != null ? (errorsHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["errors"] = (object) this.CreateHandler(this.ErrorsHandler);
      else if (this.Errors.HasValue())
        dictionary["errors"] = (object) this.Errors;
      string groupsHandler = this.GroupsHandler;
      if ((groupsHandler != null ? (groupsHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["groups"] = (object) this.CreateHandler(this.GroupsHandler);
      else if (this.Groups.HasValue())
        dictionary["groups"] = (object) this.Groups;
      string totalHandler = this.TotalHandler;
      if ((totalHandler != null ? (totalHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["total"] = (object) this.CreateHandler(this.TotalHandler);
      else if (this.Total.HasValue())
        dictionary["total"] = (object) this.Total;
      return dictionary;
    }
  }
}
