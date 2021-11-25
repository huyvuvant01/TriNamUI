// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartYAxisTitleSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartYAxisTitleSettingsBuilder<T> where T : class
  {
    public ChartYAxisTitleSettingsBuilder(ChartYAxisTitleSettings<T> container) => this.Container = container;

    protected ChartYAxisTitleSettings<T> Container { get; private set; }

    public ChartYAxisTitleSettingsBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Border(
      Action<ChartYAxisTitleBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartYAxisTitleBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Font(string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Margin(
      Action<ChartYAxisTitleMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartYAxisTitleMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Padding(
      Action<ChartYAxisTitlePaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartYAxisTitlePaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Rotation(double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Visual(string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartYAxisTitleSettingsBuilder<T> Position(
      ChartAxisTitlePosition value)
    {
      this.Container.Position = new ChartAxisTitlePosition?(value);
      return this;
    }
  }
}
