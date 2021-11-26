// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotGridTagHelper
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
  [HtmlTargetElement("kendo-pivotgrid")]
  [RestrictChildren("excel", new string[] {"pdf", "sortable", "messages", "pivot-datasource"})]
  public class PivotGridTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  PivotDataSourceTagHelper>
  {
    public PivotGridTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PivotGridTagHelper pivotGridTagHelper = this;
      context.Items[(object) pivotGridTagHelper.GetType()] = (object) pivotGridTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await pivotGridTagHelper.\u003C\u003En__0(context, output);
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
      if (this.DatacellTemplateId.HasValue())
        dictionary["dataCellTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.DatacellTemplateId)
        };
      else if (this.DatacellTemplate.HasValue())
        dictionary["dataCellTemplate"] = (object) this.DatacellTemplate;
      return this.Initializer.Initialize(this.Selector, "PivotGrid", (IDictionary<string, object>) dictionary);
    }

    public string DatasourceId { get; set; }

    public PivotDataSourceTagHelper Datasource { get; set; }

    public string DatacellTemplate { get; set; }

    public string DatacellTemplateId { get; set; }

    public string OnDataBinding { get; set; }

    public string OnDataBound { get; set; }

    public string OnExpandMember { get; set; }

    public string OnCollapseMember { get; set; }

    public string OnExcelExport { get; set; }

    public string OnPdfExport { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onDataBinding = this.OnDataBinding;
      if ((onDataBinding != null ? (onDataBinding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBinding"] = (object) this.CreateHandler(this.OnDataBinding);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onExpandMember = this.OnExpandMember;
      if ((onExpandMember != null ? (onExpandMember.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expandMember"] = (object) this.CreateHandler(this.OnExpandMember);
      string onCollapseMember = this.OnCollapseMember;
      if ((onCollapseMember != null ? (onCollapseMember.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapseMember"] = (object) this.CreateHandler(this.OnCollapseMember);
      string onExcelExport = this.OnExcelExport;
      if ((onExcelExport != null ? (onExcelExport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["excelExport"] = (object) this.CreateHandler(this.OnExcelExport);
      string onPdfExport = this.OnPdfExport;
      if ((onPdfExport != null ? (onPdfExport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pdfExport"] = (object) this.CreateHandler(this.OnPdfExport);
      return dictionary;
    }

    public bool? AutoBind { get; set; }

    public bool? Reorderable { get; set; }

    [HtmlAttributeNotBound]
    public PivotGridExcelSettingsTagHelper Excel { get; set; }

    [HtmlAttributeNotBound]
    public PivotGridPdfSettingsTagHelper Pdf { get; set; }

    public bool? Filterable { get; set; }

    [HtmlAttributeNotBound]
    public PivotGridSortableSettingsTagHelper Sortable { get; set; }

    public double? ColumnWidth { get; set; }

    public double? Height { get; set; }

    public string ColumnHeaderTemplate { get; set; }

    public string ColumnHeaderTemplateId { get; set; }

    public string KpiStatusTemplate { get; set; }

    public string KpiStatusTemplateId { get; set; }

    public string KpiTrendTemplate { get; set; }

    public string KpiTrendTemplateId { get; set; }

    public string RowHeaderTemplate { get; set; }

    public string RowHeaderTemplateId { get; set; }

    [HtmlAttributeNotBound]
    public PivotGridMessagesSettingsTagHelper Messages { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.Reorderable.HasValue)
        dictionary["reorderable"] = (object) this.Reorderable;
      if (this.Excel != null)
      {
        Dictionary<string, object> source = this.Excel.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["excel"] = (object) source;
      }
      if (this.Pdf != null)
      {
        Dictionary<string, object> source = this.Pdf.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["pdf"] = (object) source;
      }
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
      if (this.ColumnWidth.HasValue)
        dictionary["columnWidth"] = (object) this.ColumnWidth;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      if (this.ColumnHeaderTemplateId.HasValue())
        dictionary["columnHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ColumnHeaderTemplateId)
        };
      else if (this.ColumnHeaderTemplate.HasValue())
        dictionary["columnHeaderTemplate"] = (object) this.ColumnHeaderTemplate;
      if (this.KpiStatusTemplateId.HasValue())
        dictionary["kpiStatusTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.KpiStatusTemplateId)
        };
      else if (this.KpiStatusTemplate.HasValue())
        dictionary["kpiStatusTemplate"] = (object) this.KpiStatusTemplate;
      if (this.KpiTrendTemplateId.HasValue())
        dictionary["kpiTrendTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.KpiTrendTemplateId)
        };
      else if (this.KpiTrendTemplate.HasValue())
        dictionary["kpiTrendTemplate"] = (object) this.KpiTrendTemplate;
      if (this.RowHeaderTemplateId.HasValue())
        dictionary["rowHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.RowHeaderTemplateId)
        };
      else if (this.RowHeaderTemplate.HasValue())
        dictionary["rowHeaderTemplate"] = (object) this.RowHeaderTemplate;
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
