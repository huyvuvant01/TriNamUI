// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisRangeLabelsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisRangeLabelsSettingsBuilder<T> where T : class
  {
    public ChartCategoryAxisRangeLabelsSettingsBuilder(
      ChartCategoryAxisRangeLabelsSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartCategoryAxisRangeLabelsSettings<T> Container { get; private set; }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Border(
      Action<ChartCategoryAxisRangeLabelsBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisRangeLabelsBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Culture(
      string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> DateFormats(
      Action<ChartCategoryAxisRangeLabelsDateFormatsSettingsBuilder<T>> configurator)
    {
      this.Container.DateFormats.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisRangeLabelsDateFormatsSettingsBuilder<T>(this.Container.DateFormats));
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Margin(
      Action<ChartCategoryAxisRangeLabelsMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisRangeLabelsMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Mirror(
      bool value)
    {
      this.Container.Mirror = new bool?(value);
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Mirror()
    {
      this.Container.Mirror = new bool?(true);
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Padding(
      Action<ChartCategoryAxisRangeLabelsPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisRangeLabelsPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Rotation(
      Action<ChartCategoryAxisRangeLabelsRotationSettingsBuilder<T>> configurator)
    {
      this.Container.Rotation.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisRangeLabelsRotationSettingsBuilder<T>(this.Container.Rotation));
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartCategoryAxisRangeLabelsSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
