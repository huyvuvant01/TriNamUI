// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartXAxisFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartXAxisFactory<T> where T : class
  {
    public ChartXAxisFactory(List<ChartXAxis<T>> container) => this.Container = container;

    protected List<ChartXAxis<T>> Container { get; private set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    public virtual ChartXAxisBuilder<T> Add()
    {
      ChartXAxis<T> container = new ChartXAxis<T>();
      container.Chart = this.Chart;
      this.Container.Add(container);
      return new ChartXAxisBuilder<T>(container);
    }
  }
}
