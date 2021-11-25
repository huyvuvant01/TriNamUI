// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartValueAxisNotesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartValueAxisNotesSettingsBuilder<T> where T : class
  {
    public ChartValueAxisNotesSettingsBuilder(ChartValueAxisNotesSettings<T> container) => this.Container = container;

    protected ChartValueAxisNotesSettings<T> Container { get; private set; }

    public ChartValueAxisNotesSettingsBuilder<T> Position(
      ChartNotePosition value)
    {
      this.Container.Position = new ChartNotePosition?(value);
      return this;
    }

    public ChartValueAxisNotesSettingsBuilder<T> Icon(
      Action<ChartValueAxisNotesIconSettingsBuilder<T>> configurator)
    {
      this.Container.Icon.Chart = this.Container.Chart;
      configurator(new ChartValueAxisNotesIconSettingsBuilder<T>(this.Container.Icon));
      return this;
    }

    public ChartValueAxisNotesSettingsBuilder<T> Label(
      Action<ChartValueAxisNotesLabelSettingsBuilder<T>> configurator)
    {
      this.Container.Label.Chart = this.Container.Chart;
      configurator(new ChartValueAxisNotesLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public ChartValueAxisNotesSettingsBuilder<T> Line(
      Action<ChartValueAxisNotesLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartValueAxisNotesLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartValueAxisNotesSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartValueAxisNotesSettingsBuilder<T> Visual(
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
