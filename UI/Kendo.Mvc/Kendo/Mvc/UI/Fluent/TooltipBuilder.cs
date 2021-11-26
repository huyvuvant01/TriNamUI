// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TooltipBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TooltipBuilder : TooltipBuilderBase<TooltipBuilder>
  {
    public TooltipBuilder(Tooltip component)
      : base(component)
    {
    }

    public new TooltipBuilder AutoHide(bool value)
    {
      this.Container.AutoHide = new bool?(value);
      return this;
    }

    public new TooltipBuilder Callout(bool value)
    {
      this.Container.Callout = new bool?(value);
      return this;
    }

    public new TooltipBuilder Filter(string value)
    {
      this.Container.Filter = value;
      return this;
    }

    public new TooltipBuilder Iframe(bool value)
    {
      this.Container.Iframe = new bool?(value);
      return this;
    }

    public new TooltipBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public new TooltipBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public new TooltipBuilder ShowAfter(double value)
    {
      this.Container.ShowAfter = new double?(value);
      return this;
    }

    public TooltipBuilder HideAfter(double value)
    {
      this.Container.HideAfter = new double?(value);
      return this;
    }

    public TooltipBuilder Offset(double value)
    {
      this.Container.Offset = new double?(value);
      return this;
    }

    public new TooltipBuilder Position(TooltipPosition value)
    {
      this.Container.Position = new TooltipPosition?(value);
      return this;
    }

    public new TooltipBuilder ShowOn(TooltipShowOnEvent value)
    {
      this.Container.ShowOn = new TooltipShowOnEvent?(value);
      return this;
    }

    public new TooltipBuilder Events(Action<TooltipEventBuilder> configurator)
    {
      configurator(new TooltipEventBuilder(this.Container.Events));
      return this;
    }
  }
}
