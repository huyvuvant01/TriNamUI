// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisTitleSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisTitleSettingsBuilder<T> where T : class
  {
    public ChartCategoryAxisTitleSettingsBuilder(ChartCategoryAxisTitleSettings<T> container) => this.Container = container;

    protected ChartCategoryAxisTitleSettings<T> Container { get; private set; }

    public ChartCategoryAxisTitleSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Border(
      Action<ChartCategoryAxisTitleBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisTitleBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Margin(
      Action<ChartCategoryAxisTitleMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisTitleMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Padding(
      Action<ChartCategoryAxisTitlePaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisTitlePaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartCategoryAxisTitleSettingsBuilder<T> Position(
      ChartAxisTitlePosition value)
    {
      this.Container.Position = new ChartAxisTitlePosition?(value);
      return this;
    }
  }
}
