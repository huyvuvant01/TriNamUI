// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesNotesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesNotesSettingsBuilder<T> where T : class
  {
    public ChartSeriesNotesSettingsBuilder(ChartSeriesNotesSettings<T> container) => this.Container = container;

    protected ChartSeriesNotesSettings<T> Container { get; private set; }

    public ChartSeriesNotesSettingsBuilder<T> Icon(
      Action<ChartSeriesNotesIconSettingsBuilder<T>> configurator)
    {
      this.Container.Icon.Chart = this.Container.Chart;
      configurator(new ChartSeriesNotesIconSettingsBuilder<T>(this.Container.Icon));
      return this;
    }

    public ChartSeriesNotesSettingsBuilder<T> Label(
      Action<ChartSeriesNotesLabelSettingsBuilder<T>> configurator)
    {
      this.Container.Label.Chart = this.Container.Chart;
      configurator(new ChartSeriesNotesLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public ChartSeriesNotesSettingsBuilder<T> Line(
      Action<ChartSeriesNotesLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartSeriesNotesLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartSeriesNotesSettingsBuilder<T> Visual(string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesNotesSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesNotesSettingsBuilder<T> Position(
      ChartNotePosition value)
    {
      this.Container.Position = new ChartNotePosition?(value);
      return this;
    }
  }
}
