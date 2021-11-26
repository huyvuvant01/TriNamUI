// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ToolBarBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ToolBarBuilder : WidgetBuilderBase<ToolBar, ToolBarBuilder>
  {
    public ToolBarBuilder(ToolBar component)
      : base(component)
    {
    }

    public ToolBarBuilder Resizable(bool value)
    {
      this.Container.Resizable = new bool?(value);
      return this;
    }

    public ToolBarBuilder Items(Action<ToolBarItemFactory> configurator)
    {
      configurator(new ToolBarItemFactory(this.Container.Items)
      {
        ToolBar = this.Container
      });
      return this;
    }

    public ToolBarBuilder Events(Action<ToolBarEventBuilder> configurator)
    {
      configurator(new ToolBarEventBuilder(this.Container.Events));
      return this;
    }
  }
}
