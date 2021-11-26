// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotGridBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotGridBuilder<T> : WidgetBuilderBase<PivotGrid<T>, PivotGridBuilder<T>>
    where T : class
  {
    public PivotGridBuilder(PivotGrid<T> component)
      : base(component)
    {
    }

    public PivotGridBuilder<T> Configurator(string configurator)
    {
      this.Component.Configurator = configurator;
      return this;
    }

    public PivotGridBuilder<T> DataSource(
      Action<PivotDataSourceBuilder<T>> configurator)
    {
      configurator(new PivotDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public PivotGridBuilder<T> DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public PivotGridBuilder<T> BindTo(IEnumerable<T> dataSource)
    {
      this.Component.DataSource.Data = (IEnumerable) dataSource;
      return this;
    }

    public PivotGridBuilder<T> Messages(
      Action<PivotGridMessagesBuilder> addViewAction)
    {
      PivotGridMessagesBuilder gridMessagesBuilder = new PivotGridMessagesBuilder(this.Component.Messages);
      addViewAction(gridMessagesBuilder);
      return this;
    }

    public PivotGridBuilder<T> KPIStatusTemplate(string template)
    {
      this.Component.KPIStatusTemplate = template;
      return this;
    }

    public PivotGridBuilder<T> KPIStatusTemplateId(string templateId)
    {
      this.Component.KPIStatusTemplateId = templateId;
      return this;
    }

    public PivotGridBuilder<T> KPITrendTemplate(string template)
    {
      this.Component.KPITrendTemplate = template;
      return this;
    }

    public PivotGridBuilder<T> KPITrendTemplateId(string templateId)
    {
      this.Component.KPITrendTemplateId = templateId;
      return this;
    }

    public PivotGridBuilder<T> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public PivotGridBuilder<T> Reorderable(bool value)
    {
      this.Container.Reorderable = new bool?(value);
      return this;
    }

    public PivotGridBuilder<T> Excel(
      Action<PivotGridExcelSettingsBuilder<T>> configurator)
    {
      this.Container.Excel.PivotGrid = this.Container;
      configurator(new PivotGridExcelSettingsBuilder<T>(this.Container.Excel));
      return this;
    }

    public PivotGridBuilder<T> Pdf(
      Action<PivotGridPdfSettingsBuilder<T>> configurator)
    {
      this.Container.Pdf.PivotGrid = this.Container;
      configurator(new PivotGridPdfSettingsBuilder<T>(this.Container.Pdf));
      return this;
    }

    public PivotGridBuilder<T> Filterable(bool value)
    {
      this.Container.Filterable = new bool?(value);
      return this;
    }

    public PivotGridBuilder<T> Filterable()
    {
      this.Container.Filterable = new bool?(true);
      return this;
    }

    public PivotGridBuilder<T> Sortable(
      Action<PivotGridSortableSettingsBuilder<T>> configurator)
    {
      this.Container.Sortable.Enabled = new bool?(true);
      this.Container.Sortable.PivotGrid = this.Container;
      configurator(new PivotGridSortableSettingsBuilder<T>(this.Container.Sortable));
      return this;
    }

    public PivotGridBuilder<T> Sortable()
    {
      this.Container.Sortable.Enabled = new bool?(true);
      return this;
    }

    public PivotGridBuilder<T> Sortable(bool enabled)
    {
      this.Container.Sortable.Enabled = new bool?(enabled);
      return this;
    }

    public PivotGridBuilder<T> ColumnWidth(double value)
    {
      this.Container.ColumnWidth = new double?(value);
      return this;
    }

    public PivotGridBuilder<T> Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public PivotGridBuilder<T> ColumnHeaderTemplate(string value)
    {
      this.Container.ColumnHeaderTemplate = value;
      return this;
    }

    public PivotGridBuilder<T> ColumnHeaderTemplateId(string templateId)
    {
      this.Container.ColumnHeaderTemplateId = templateId;
      return this;
    }

    public PivotGridBuilder<T> DataCellTemplate(string value)
    {
      this.Container.DataCellTemplate = value;
      return this;
    }

    public PivotGridBuilder<T> DataCellTemplateId(string templateId)
    {
      this.Container.DataCellTemplateId = templateId;
      return this;
    }

    public PivotGridBuilder<T> RowHeaderTemplate(string value)
    {
      this.Container.RowHeaderTemplate = value;
      return this;
    }

    public PivotGridBuilder<T> RowHeaderTemplateId(string templateId)
    {
      this.Container.RowHeaderTemplateId = templateId;
      return this;
    }

    public PivotGridBuilder<T> Events(Action<PivotGridEventBuilder> configurator)
    {
      configurator(new PivotGridEventBuilder(this.Container.Events));
      return this;
    }
  }
}
