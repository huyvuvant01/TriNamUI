// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SplitterBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SplitterBuilder : WidgetBuilderBase<Splitter, SplitterBuilder>
  {
    public SplitterBuilder(Splitter component)
      : base(component)
    {
    }

    public SplitterBuilder Panes(Action<SplitterPaneFactory> configurator)
    {
      configurator(new SplitterPaneFactory(this.Container.Panes)
      {
        Splitter = this.Container
      });
      return this;
    }

    public SplitterBuilder Orientation(SplitterOrientation value)
    {
      this.Container.Orientation = new SplitterOrientation?(value);
      return this;
    }

    public SplitterBuilder Events(Action<SplitterEventBuilder> configurator)
    {
      configurator(new SplitterEventBuilder(this.Container.Events));
      return this;
    }
  }
}
