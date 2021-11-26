// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotConfiguratorTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-pivotconfigurator")]
  [RestrictChildren("sortable", new string[] {"messages", "pivot-datasource"})]
  public class PivotConfiguratorTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  PivotDataSourceTagHelper>
  {
    public PivotConfiguratorTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PivotConfiguratorTagHelper configuratorTagHelper = this;
      context.Items[(object) configuratorTagHelper.GetType()] = (object) configuratorTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await configuratorTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      return this.Initializer.Initialize(this.Selector, "PivotConfigurator", (IDictionary<string, object>) dictionary);
    }

    public string DatasourceId { get; set; }

    public PivotDataSourceTagHelper Datasource { get; set; }

    protected override Dictionary<string, object> SerializeEvents() => new Dictionary<string, object>();

    public bool? Filterable { get; set; }

    [HtmlAttributeNotBound]
    public PivotConfiguratorSortableSettingsTagHelper Sortable { get; set; }

    public double? Height { get; set; }

    [HtmlAttributeNotBound]
    public PivotConfiguratorMessagesSettingsTagHelper Messages { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Filterable.HasValue)
        dictionary["filterable"] = (object) this.Filterable;
      if (this.Sortable != null)
      {
        Dictionary<string, object> source = this.Sortable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Sortable.Enabled.HasValue || this.Sortable.Enabled.Value))
          dictionary["sortable"] = (object) source;
        else if (this.Sortable.Enabled.HasValue && this.Sortable.Enabled.Value)
          dictionary["sortable"] = (object) this.Sortable.Enabled;
      }
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      return dictionary;
    }
  }
}
