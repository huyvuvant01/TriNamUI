// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartXAxisNotesIconSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartXAxisNotesIconSettingsBuilder<T> where T : class
  {
    public ChartXAxisNotesIconSettingsBuilder(ChartXAxisNotesIconSettings<T> container) => this.Container = container;

    protected ChartXAxisNotesIconSettings<T> Container { get; private set; }

    public ChartXAxisNotesIconSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartXAxisNotesIconSettingsBuilder<T> Border(
      Action<ChartXAxisNotesIconBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartXAxisNotesIconBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartXAxisNotesIconSettingsBuilder<T> Size(double value)
    {
      this.Container.Size = new double?(value);
      return this;
    }

    public ChartXAxisNotesIconSettingsBuilder<T> Type(string value)
    {
      this.Container.Type = value;
      return this;
    }

    public ChartXAxisNotesIconSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
