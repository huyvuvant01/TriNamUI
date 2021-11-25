// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TileLayoutBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TileLayoutBuilder : WidgetBuilderBase<TileLayout, TileLayoutBuilder>
  {
    public TileLayoutBuilder(TileLayout component)
      : base(component)
    {
    }

    public TileLayoutBuilder Columns(double value)
    {
      this.Container.Columns = new double?(value);
      return this;
    }

    public TileLayoutBuilder ColumnsWidth(string value)
    {
      this.Container.ColumnsWidth = value;
      return this;
    }

    public TileLayoutBuilder Containers(
      Action<TileLayoutContainerFactory> configurator)
    {
      configurator(new TileLayoutContainerFactory(this.Container.Containers)
      {
        TileLayout = this.Container
      });
      return this;
    }

    public TileLayoutBuilder Gap(Action<TileLayoutGapSettingsBuilder> configurator)
    {
      this.Container.Gap.TileLayout = this.Container;
      configurator(new TileLayoutGapSettingsBuilder(this.Container.Gap));
      return this;
    }

    public TileLayoutBuilder Height(string value)
    {
      this.Container.Height = value;
      return this;
    }

    public TileLayoutBuilder Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public TileLayoutBuilder Navigatable()
    {
      this.Container.Navigatable = new bool?(true);
      return this;
    }

    public TileLayoutBuilder Reorderable(bool value)
    {
      this.Container.Reorderable = new bool?(value);
      return this;
    }

    public TileLayoutBuilder Reorderable()
    {
      this.Container.Reorderable = new bool?(true);
      return this;
    }

    public TileLayoutBuilder Resizable(bool value)
    {
      this.Container.Resizable = new bool?(value);
      return this;
    }

    public TileLayoutBuilder Resizable()
    {
      this.Container.Resizable = new bool?(true);
      return this;
    }

    public TileLayoutBuilder RowsHeight(string value)
    {
      this.Container.RowsHeight = value;
      return this;
    }

    public TileLayoutBuilder Width(string value)
    {
      this.Container.Width = value;
      return this;
    }

    public TileLayoutBuilder Events(Action<TileLayoutEventBuilder> configurator)
    {
      configurator(new TileLayoutEventBuilder(this.Container.Events));
      return this;
    }
  }
}
