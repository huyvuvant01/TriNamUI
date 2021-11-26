// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisNotesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisNotesSettingsBuilder<T> where T : class
  {
    public ChartCategoryAxisNotesSettingsBuilder(ChartCategoryAxisNotesSettings<T> container) => this.Container = container;

    protected ChartCategoryAxisNotesSettings<T> Container { get; private set; }

    public ChartCategoryAxisNotesSettingsBuilder<T> Position(
      ChartNotePosition value)
    {
      this.Container.Position = new ChartNotePosition?(value);
      return this;
    }

    public ChartCategoryAxisNotesSettingsBuilder<T> Icon(
      Action<ChartCategoryAxisNotesIconSettingsBuilder<T>> configurator)
    {
      this.Container.Icon.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisNotesIconSettingsBuilder<T>(this.Container.Icon));
      return this;
    }

    public ChartCategoryAxisNotesSettingsBuilder<T> Label(
      Action<ChartCategoryAxisNotesLabelSettingsBuilder<T>> configurator)
    {
      this.Container.Label.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisNotesLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public ChartCategoryAxisNotesSettingsBuilder<T> Line(
      Action<ChartCategoryAxisNotesLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisNotesLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartCategoryAxisNotesSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartCategoryAxisNotesSettingsBuilder<T> Visual(
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
