// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartValueAxisLabelsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartValueAxisLabelsSettingsBuilder<T> where T : class
  {
    public ChartValueAxisLabelsSettingsBuilder(ChartValueAxisLabelsSettings<T> container) => this.Container = container;

    protected ChartValueAxisLabelsSettings<T> Container { get; private set; }

    public ChartValueAxisLabelsSettingsBuilder<T> Margin(
      int top,
      int right,
      int bottom,
      int left)
    {
      this.Container.Margin.Top = new double?((double) top);
      this.Container.Margin.Right = new double?((double) right);
      this.Container.Margin.Bottom = new double?((double) bottom);
      this.Container.Margin.Left = new double?((double) left);
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Padding(
      int top,
      int right,
      int bottom,
      int left)
    {
      this.Container.Padding.Top = new double?((double) top);
      this.Container.Padding.Right = new double?((double) right);
      this.Container.Padding.Bottom = new double?((double) bottom);
      this.Container.Padding.Left = new double?((double) left);
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation.Angle = new double?(value);
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Border(
      Action<ChartValueAxisLabelsBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartValueAxisLabelsBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Margin(
      Action<ChartValueAxisLabelsMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartValueAxisLabelsMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Mirror(
      bool value)
    {
      this.Container.Mirror = new bool?(value);
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Padding(
      Action<ChartValueAxisLabelsPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartValueAxisLabelsPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Rotation(
      Action<ChartValueAxisLabelsRotationSettingsBuilder<T>> configurator)
    {
      this.Container.Rotation.Chart = this.Container.Chart;
      configurator(new ChartValueAxisLabelsRotationSettingsBuilder<T>(this.Container.Rotation));
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Skip(
      double value)
    {
      this.Container.Skip = new double?(value);
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Step(
      double value)
    {
      this.Container.Step = new double?(value);
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartValueAxisLabelsSettingsBuilder<T> Position(
      ChartAxisLabelsPosition value)
    {
      this.Container.Position = new ChartAxisLabelsPosition?(value);
      return this;
    }
  }
}
