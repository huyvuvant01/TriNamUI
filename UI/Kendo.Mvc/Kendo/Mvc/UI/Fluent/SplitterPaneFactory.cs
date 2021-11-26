// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SplitterPaneFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SplitterPaneFactory
  {
    public SplitterPaneFactory(List<SplitterPane> container) => this.Container = container;

    protected List<SplitterPane> Container { get; private set; }

    public Splitter Splitter { get; set; }

    public virtual SplitterPaneBuilder Add()
    {
      SplitterPane container = new SplitterPane();
      container.Splitter = this.Splitter;
      this.Container.Add(container);
      return new SplitterPaneBuilder(container);
    }
  }
}
