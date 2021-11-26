// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GanttDependencyDataSourceTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-ganttdependencydatasource")]
  [HtmlTargetElement("dependency-datasource", ParentTag = "kendo-gantt")]
  [RestrictChildren("aggregates", new string[] {"filters", "groups", "schema", "sorts", "transport"})]
  public class GanttDependencyDataSourceTagHelper : DataSourceTagHelper
  {
    public GanttDependencyDataSourceTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    protected override void SetDataSource(object item)
    {
      if (!(item is GanttTagHelper))
        return;
      (item as GanttTagHelper).DependancyDatasource = this;
      this.IsNested = true;
    }

    protected override void AddSelfToContext(TagHelperContext context) => context.Items[(object) typeof (DataSourceTagHelper)] = (object) this;

    protected override string GetInitializationScript() => this.Name + " = new kendo.data.GanttDependencyDataSource(" + this.Initializer.Serialize((IDictionary<string, object>) this.Serialize()) + ");";

    internal override Dictionary<string, object> Serialize() => base.Serialize();
  }
}
