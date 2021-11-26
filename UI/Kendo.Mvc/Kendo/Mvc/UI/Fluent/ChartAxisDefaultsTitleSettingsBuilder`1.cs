// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartAxisDefaultsTitleSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartAxisDefaultsTitleSettingsBuilder<T> where T : class
  {
    public ChartAxisDefaultsTitleSettingsBuilder(ChartAxisDefaultsTitleSettings<T> container) => this.Container = container;

    protected ChartAxisDefaultsTitleSettings<T> Container { get; private set; }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Border(
      Action<ChartAxisDefaultsTitleBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsTitleBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Margin(
      Action<ChartAxisDefaultsTitleMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsTitleMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Padding(
      Action<ChartAxisDefaultsTitlePaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsTitlePaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartAxisDefaultsTitleSettingsBuilder<T> Visual(
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
