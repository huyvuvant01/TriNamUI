// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FloatingActionButtonBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FloatingActionButtonBuilder : 
    WidgetBuilderBase<FloatingActionButton, FloatingActionButtonBuilder>
  {
    public FloatingActionButtonBuilder(FloatingActionButton component)
      : base(component)
    {
    }

    public FloatingActionButtonBuilder AlignOffset(
      Action<FloatingActionButtonAlignOffsetBuilder> configurator)
    {
      configurator(new FloatingActionButtonAlignOffsetBuilder(this.Container.AlignOffset));
      return this;
    }

    public FloatingActionButtonBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public FloatingActionButtonBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public FloatingActionButtonBuilder Items(
      Action<FloatingActionButtonItemFactory> configurator)
    {
      configurator(new FloatingActionButtonItemFactory(this.Container.Items)
      {
        FloatingActionButton = this.Container
      });
      return this;
    }

    public FloatingActionButtonBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public FloatingActionButtonBuilder Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public FloatingActionButtonBuilder Size(
      FloatingActionButtonSize value)
    {
      this.Container.Size = new FloatingActionButtonSize?(value);
      return this;
    }

    public FloatingActionButtonBuilder Align(
      FloatingActionButtonAlign value)
    {
      this.Container.Align = new FloatingActionButtonAlign?(value);
      return this;
    }

    public FloatingActionButtonBuilder PositionMode(
      FloatingActionButtonPositionMode value)
    {
      this.Container.PositionMode = new FloatingActionButtonPositionMode?(value);
      return this;
    }

    public FloatingActionButtonBuilder Shape(
      FloatingActionButtonShape value)
    {
      this.Container.Shape = new FloatingActionButtonShape?(value);
      return this;
    }

    public FloatingActionButtonBuilder ThemeColor(
      FloatingActionButtonThemeColor value)
    {
      this.Container.ThemeColor = new FloatingActionButtonThemeColor?(value);
      return this;
    }

    public FloatingActionButtonBuilder Events(
      Action<FloatingActionButtonEventBuilder> configurator)
    {
      configurator(new FloatingActionButtonEventBuilder(this.Container.Events));
      return this;
    }
  }
}
