// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RangeSliderBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
  public class RangeSliderBuilder<T> : WidgetBuilderBase<RangeSlider<T>, RangeSliderBuilder<T>>
    where T : struct, IComparable
  {
    public RangeSliderBuilder(RangeSlider<T> component)
      : base(component)
    {
    }

    public RangeSliderBuilder<T> Values(T? selectionStart, T? selectionEnd)
    {
      if (selectionStart.HasValue)
        this.Component.SelectionStart = new T?(selectionStart.Value);
      if (selectionEnd.HasValue)
        this.Component.SelectionEnd = new T?(selectionEnd.Value);
      return this;
    }

    public RangeSliderBuilder<T> Values(T[] range)
    {
      if (range == null)
        return this;
      if (((IEnumerable<T>) range).Count<T>() >= 1)
        this.Component.SelectionStart = new T?(((IEnumerable<T>) range).First<T>());
      if (((IEnumerable<T>) range).Count<T>() > 1)
        this.Component.SelectionEnd = new T?(range[1]);
      return this;
    }

    public RangeSliderBuilder<T> Tooltip(bool value)
    {
      this.Container.Tooltip.RangeSlider = this.Container;
      this.Container.Tooltip.Enabled = new bool?(value);
      return this;
    }

    public RangeSliderBuilder<T> LargeStep(T? value)
    {
      this.Container.LargeStep = value;
      return this;
    }

    public RangeSliderBuilder<T> LeftDragHandleTitle(string value)
    {
      this.Container.LeftDragHandleTitle = value;
      return this;
    }

    public RangeSliderBuilder<T> Max(T? value)
    {
      this.Container.Max = value;
      return this;
    }

    public RangeSliderBuilder<T> Min(T? value)
    {
      this.Container.Min = value;
      return this;
    }

    public RangeSliderBuilder<T> Orientation(SliderOrientation value)
    {
      this.Container.Orientation = new SliderOrientation?(value);
      return this;
    }

    public RangeSliderBuilder<T> RightDragHandleTitle(string value)
    {
      this.Container.RightDragHandleTitle = value;
      return this;
    }

    public RangeSliderBuilder<T> SelectionEnd(T? value)
    {
      this.Container.SelectionEnd = value;
      return this;
    }

    public RangeSliderBuilder<T> SelectionStart(T? value)
    {
      this.Container.SelectionStart = value;
      return this;
    }

    public RangeSliderBuilder<T> SmallStep(T? value)
    {
      this.Container.SmallStep = value;
      return this;
    }

    public RangeSliderBuilder<T> TickPlacement(SliderTickPlacement value)
    {
      this.Container.TickPlacement = new SliderTickPlacement?(value);
      return this;
    }

    public RangeSliderBuilder<T> Tooltip(
      Action<RangeSliderTooltipSettingsBuilder<T>> configurator)
    {
      this.Container.Tooltip.RangeSlider = this.Container;
      configurator(new RangeSliderTooltipSettingsBuilder<T>(this.Container.Tooltip));
      return this;
    }

    public RangeSliderBuilder<T> Events(
      Action<RangeSliderEventBuilder> configurator)
    {
      configurator(new RangeSliderEventBuilder(this.Container.Events));
      return this;
    }
  }
}
