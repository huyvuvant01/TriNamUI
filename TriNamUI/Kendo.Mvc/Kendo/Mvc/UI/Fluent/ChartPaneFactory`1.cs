// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartPaneFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartPaneFactory<T> where T : class
  {
    public ChartPaneFactory(List<ChartPane<T>> container) => this.Container = container;

    protected List<ChartPane<T>> Container { get; private set; }

    public virtual ChartPaneBuilder<T> Add(string name)
    {
      ChartPane<T> container = new ChartPane<T>();
      container.Name = name;
      this.Container.Add(container);
      return new ChartPaneBuilder<T>(container);
    }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    public virtual ChartPaneBuilder<T> Add()
    {
      ChartPane<T> container = new ChartPane<T>();
      container.Chart = this.Chart;
      this.Container.Add(container);
      return new ChartPaneBuilder<T>(container);
    }
  }
}
