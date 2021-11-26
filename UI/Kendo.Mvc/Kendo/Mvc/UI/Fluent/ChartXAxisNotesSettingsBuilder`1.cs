// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartXAxisNotesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartXAxisNotesSettingsBuilder<T> where T : class
  {
    public ChartXAxisNotesSettingsBuilder(ChartXAxisNotesSettings<T> container) => this.Container = container;

    protected ChartXAxisNotesSettings<T> Container { get; private set; }

    public ChartXAxisNotesSettingsBuilder<T> Position(
      ChartNotePosition value)
    {
      this.Container.Position = new ChartNotePosition?(value);
      return this;
    }

    public ChartXAxisNotesSettingsBuilder<T> Icon(
      Action<ChartXAxisNotesIconSettingsBuilder<T>> configurator)
    {
      this.Container.Icon.Chart = this.Container.Chart;
      configurator(new ChartXAxisNotesIconSettingsBuilder<T>(this.Container.Icon));
      return this;
    }

    public ChartXAxisNotesSettingsBuilder<T> Label(
      Action<ChartXAxisNotesLabelSettingsBuilder<T>> configurator)
    {
      this.Container.Label.Chart = this.Container.Chart;
      configurator(new ChartXAxisNotesLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public ChartXAxisNotesSettingsBuilder<T> Line(
      Action<ChartXAxisNotesLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartXAxisNotesLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartXAxisNotesSettingsBuilder<T> Visual(string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartXAxisNotesSettingsBuilder<T> Visual(
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
