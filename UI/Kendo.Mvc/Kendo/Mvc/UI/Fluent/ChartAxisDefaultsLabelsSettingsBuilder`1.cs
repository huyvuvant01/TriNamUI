// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartAxisDefaultsLabelsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartAxisDefaultsLabelsSettingsBuilder<T> where T : class
  {
    public ChartAxisDefaultsLabelsSettingsBuilder(ChartAxisDefaultsLabelsSettings<T> container) => this.Container = container;

    protected ChartAxisDefaultsLabelsSettings<T> Container { get; private set; }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Margin(
      Action<ChartAxisDefaultsLabelsMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsLabelsMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Mirror(
      bool value)
    {
      this.Container.Mirror = new bool?(value);
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Mirror()
    {
      this.Container.Mirror = new bool?(true);
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Padding(
      Action<ChartAxisDefaultsLabelsPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsLabelsPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Rotation(
      Action<ChartAxisDefaultsLabelsRotationSettingsBuilder<T>> configurator)
    {
      this.Container.Rotation.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsLabelsRotationSettingsBuilder<T>(this.Container.Rotation));
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Skip(
      double value)
    {
      this.Container.Skip = new double?(value);
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Step(
      double value)
    {
      this.Container.Step = new double?(value);
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartAxisDefaultsLabelsSettingsBuilder<T> Visual(
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
