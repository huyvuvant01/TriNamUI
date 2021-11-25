// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartValueAxisTitleSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartValueAxisTitleSettingsBuilder<T> where T : class
  {
    public ChartValueAxisTitleSettingsBuilder(ChartValueAxisTitleSettings<T> container) => this.Container = container;

    protected ChartValueAxisTitleSettings<T> Container { get; private set; }

    public ChartValueAxisTitleSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Border(
      Action<ChartValueAxisTitleBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartValueAxisTitleBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Font(string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Margin(
      Action<ChartValueAxisTitleMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartValueAxisTitleMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Padding(
      Action<ChartValueAxisTitlePaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartValueAxisTitlePaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartValueAxisTitleSettingsBuilder<T> Position(
      ChartAxisTitlePosition value)
    {
      this.Container.Position = new ChartAxisTitlePosition?(value);
      return this;
    }
  }
}
