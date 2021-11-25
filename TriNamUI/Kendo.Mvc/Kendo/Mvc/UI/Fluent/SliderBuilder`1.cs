// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SliderBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SliderBuilder<T> : WidgetBuilderBase<Slider<T>, SliderBuilder<T>>
    where T : struct, IComparable
  {
    public SliderBuilder(Slider<T> component)
      : base(component)
    {
    }

    public SliderBuilder<T> Tooltip(bool value)
    {
      this.Container.Tooltip.Slider = this.Container;
      this.Container.Tooltip.Enabled = new bool?(value);
      return this;
    }

    public SliderBuilder<T> DecreaseButtonTitle(string value)
    {
      this.Container.DecreaseButtonTitle = value;
      return this;
    }

    public SliderBuilder<T> DragHandleTitle(string value)
    {
      this.Container.DragHandleTitle = value;
      return this;
    }

    public SliderBuilder<T> IncreaseButtonTitle(string value)
    {
      this.Container.IncreaseButtonTitle = value;
      return this;
    }

    public SliderBuilder<T> LargeStep(T? value)
    {
      this.Container.LargeStep = value;
      return this;
    }

    public SliderBuilder<T> Max(T? value)
    {
      this.Container.Max = value;
      return this;
    }

    public SliderBuilder<T> Min(T? value)
    {
      this.Container.Min = value;
      return this;
    }

    public SliderBuilder<T> ShowButtons(bool value)
    {
      this.Container.ShowButtons = new bool?(value);
      return this;
    }

    public SliderBuilder<T> SmallStep(T? value)
    {
      this.Container.SmallStep = value;
      return this;
    }

    public SliderBuilder<T> Tooltip(
      Action<SliderTooltipSettingsBuilder<T>> configurator)
    {
      this.Container.Tooltip.Slider = this.Container;
      configurator(new SliderTooltipSettingsBuilder<T>(this.Container.Tooltip));
      return this;
    }

    public SliderBuilder<T> Value(T? value)
    {
      this.Container.Value = value;
      return this;
    }

    public SliderBuilder<T> Orientation(SliderOrientation value)
    {
      this.Container.Orientation = new SliderOrientation?(value);
      return this;
    }

    public SliderBuilder<T> TickPlacement(SliderTickPlacement value)
    {
      this.Container.TickPlacement = new SliderTickPlacement?(value);
      return this;
    }

    public SliderBuilder<T> Events(Action<SliderEventBuilder> configurator)
    {
      configurator(new SliderEventBuilder(this.Container.Events));
      return this;
    }
  }
}
