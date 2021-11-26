// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerDataSourceSchemaSettingsTagHelper
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
  [HtmlTargetElement("schema", ParentTag = "kendo-schedulerdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("schema", ParentTag = "scheduler-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("scheduler-model", new string[] {})]
  [SuppressTagRendering]
  public class SchedulerDataSourceSchemaSettingsTagHelper : DataSourceSchemaSettingsTagHelper
  {
    public 
    #nullable disable
    SchedulerDataSourceSchemaModelSettingsTagHelper Model { get; set; }

    public string Timezone { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToContext(TagHelperContext context) => context.Items[(object) typeof (DataSourceSchemaSettingsTagHelper)] = (object) this;

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceTagHelper).Schema = (DataSourceSchemaSettingsTagHelper) this;
    }

    internal override Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = base.Serialize();
      if (this.Model != null)
      {
        Dictionary<string, object> source = this.Model.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["model"] = (object) source;
      }
      string timezone = this.Timezone;
      if ((timezone != null ? (timezone.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["timezone"] = (object) this.Timezone;
      return dictionary;
    }
  }
}
