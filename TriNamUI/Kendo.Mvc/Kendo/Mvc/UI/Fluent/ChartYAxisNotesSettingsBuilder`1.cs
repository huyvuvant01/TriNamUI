// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartYAxisNotesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartYAxisNotesSettingsBuilder<T> where T : class
  {
    public ChartYAxisNotesSettingsBuilder(ChartYAxisNotesSettings<T> container) => this.Container = container;

    protected ChartYAxisNotesSettings<T> Container { get; private set; }

    public ChartYAxisNotesSettingsBuilder<T> Position(
      ChartNotePosition value)
    {
      this.Container.Position = new ChartNotePosition?(value);
      return this;
    }

    public ChartYAxisNotesSettingsBuilder<T> Icon(
      Action<ChartYAxisNotesIconSettingsBuilder<T>> configurator)
    {
      this.Container.Icon.Chart = this.Container.Chart;
      configurator(new ChartYAxisNotesIconSettingsBuilder<T>(this.Container.Icon));
      return this;
    }

    public ChartYAxisNotesSettingsBuilder<T> Label(
      Action<ChartYAxisNotesLabelSettingsBuilder<T>> configurator)
    {
      this.Container.Label.Chart = this.Container.Chart;
      configurator(new ChartYAxisNotesLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public ChartYAxisNotesSettingsBuilder<T> Line(
      Action<ChartYAxisNotesLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartYAxisNotesLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartYAxisNotesSettingsBuilder<T> Visual(string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartYAxisNotesSettingsBuilder<T> Visual(
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
