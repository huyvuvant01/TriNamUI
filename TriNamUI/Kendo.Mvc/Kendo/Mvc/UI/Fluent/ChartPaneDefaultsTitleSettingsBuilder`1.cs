// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartPaneDefaultsTitleSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartPaneDefaultsTitleSettingsBuilder<T> where T : class
  {
    public ChartPaneDefaultsTitleSettingsBuilder(ChartPaneDefaultsTitleSettings<T> container) => this.Container = container;

    protected ChartPaneDefaultsTitleSettings<T> Container { get; private set; }

    public ChartPaneDefaultsTitleSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartPaneDefaultsTitleSettingsBuilder<T> Border(
      Action<ChartPaneDefaultsTitleBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartPaneDefaultsTitleBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartPaneDefaultsTitleSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartPaneDefaultsTitleSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartPaneDefaultsTitleSettingsBuilder<T> Margin(
      Action<ChartPaneDefaultsTitleMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartPaneDefaultsTitleMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartPaneDefaultsTitleSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public ChartPaneDefaultsTitleSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartPaneDefaultsTitleSettingsBuilder<T> Visual(
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
