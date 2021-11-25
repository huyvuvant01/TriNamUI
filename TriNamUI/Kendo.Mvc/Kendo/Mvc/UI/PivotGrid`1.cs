// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotGrid`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PivotGrid<T> : WidgetBase where T : class
  {
    public PivotGrid(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new PivotDataSource(this.ModelMetadataProvider);
      this.DataSource.ModelType(typeof (T));
    }

    public PivotGridMessages Messages { get; } = new PivotGridMessages();

    public string Configurator { get; set; }

    public PivotDataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public string KPIStatusTemplate { get; set; }

    public string KPIStatusTemplateId { get; set; }

    public string KPITrendTemplate { get; set; }

    public string KPITrendTemplateId { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (!string.IsNullOrEmpty(this.Configurator))
        dictionary["configurator"] = (object) this.Configurator;
      if (this.KPIStatusTemplateId.HasValue())
        dictionary["kpiStatusTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.KPIStatusTemplateId)
        };
      else if (this.KPIStatusTemplate.HasValue())
        dictionary["kpiStatusTemplate"] = (object) this.KPIStatusTemplate;
      if (this.KPITrendTemplateId.HasValue())
        dictionary["kpiTrendTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.KPITrendTemplateId)
        };
      else if (this.KPITrendTemplate.HasValue())
        dictionary["kpiTrendTemplate"] = (object) this.KPITrendTemplate;
      IDictionary<string, object> json = this.Messages.ToJson();
      if (json.Count > 0)
        dictionary["messages"] = (object) json;
      if (this.DataSourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      else
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (PivotGrid<T>), (IDictionary<string, object>) dictionary));
    }

    public bool? AutoBind { get; set; }

    public bool? Reorderable { get; set; }

    public PivotGridExcelSettings<T> Excel { get; } = new PivotGridExcelSettings<T>();

    public PivotGridPdfSettings<T> Pdf { get; } = new PivotGridPdfSettings<T>();

    public bool? Filterable { get; set; }

    public PivotGridSortableSettings<T> Sortable { get; } = new PivotGridSortableSettings<T>();

    public double? ColumnWidth { get; set; }

    public double? Height { get; set; }

    public string ColumnHeaderTemplate { get; set; }

    public string ColumnHeaderTemplateId { get; set; }

    public string DataCellTemplate { get; set; }

    public string DataCellTemplateId { get; set; }

    public string RowHeaderTemplate { get; set; }

    public string RowHeaderTemplateId { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.Reorderable.HasValue)
        dictionary["reorderable"] = (object) this.Reorderable;
      Dictionary<string, object> source1 = this.Excel.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["excel"] = (object) source1;
      Dictionary<string, object> source2 = this.Pdf.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["pdf"] = (object) source2;
      if (this.Filterable.HasValue)
        dictionary["filterable"] = (object) this.Filterable;
      Dictionary<string, object> source3 = this.Sortable.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["sortable"] = (object) source3;
      else if (this.Sortable.Enabled.HasValue)
        dictionary["sortable"] = (object) this.Sortable.Enabled;
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
      if (this.DataCellTemplateId.HasValue())
        dictionary["dataCellTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.DataCellTemplateId)
        };
      else if (this.DataCellTemplate.HasValue())
        dictionary["dataCellTemplate"] = (object) this.DataCellTemplate;
      if (this.RowHeaderTemplateId.HasValue())
        dictionary["rowHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.RowHeaderTemplateId)
        };
      else if (this.RowHeaderTemplate.HasValue())
        dictionary["rowHeaderTemplate"] = (object) this.RowHeaderTemplate;
      return dictionary;
    }
  }
}
