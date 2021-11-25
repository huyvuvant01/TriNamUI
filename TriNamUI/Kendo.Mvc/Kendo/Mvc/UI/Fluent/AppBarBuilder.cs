// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.AppBarBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class AppBarBuilder : WidgetBuilderBase<AppBar, AppBarBuilder>
  {
    public AppBarBuilder(AppBar component)
      : base(component)
    {
    }

    public AppBarBuilder Items(Action<AppBarItemFactory> configurator)
    {
      configurator(new AppBarItemFactory(this.Container.Items)
      {
        AppBar = this.Container
      });
      return this;
    }

    public AppBarBuilder Position(AppBarPosition value)
    {
      this.Container.Position = new AppBarPosition?(value);
      return this;
    }

    public AppBarBuilder PositionMode(AppBarPositionMode value)
    {
      this.Container.PositionMode = new AppBarPositionMode?(value);
      return this;
    }

    public AppBarBuilder ThemeColor(AppBarThemeColor value)
    {
      this.Container.ThemeColor = new AppBarThemeColor?(value);
      return this;
    }

    public AppBarBuilder Events(Action<AppBarEventBuilder> configurator)
    {
      configurator(new AppBarEventBuilder(this.Container.Events));
      return this;
    }
  }
}
