// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TimePickerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
  public class TimePickerBuilder : WidgetBuilderBase<TimePicker, TimePickerBuilder>
  {
    public TimePickerBuilder(TimePicker component)
      : base(component)
    {
    }

    public TimePickerBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public TimePickerBuilder Animation(
      Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public TimePickerBuilder Enable(bool value)
    {
      this.Component.Enabled = value;
      return this;
    }

    public TimePickerBuilder Value(DateTime? date)
    {
      this.Component.Value = date;
      return this;
    }

    public TimePickerBuilder Value(string date)
    {
      DateTime result;
      if (DateTime.TryParse(date, out result))
        this.Component.Value = new DateTime?(result);
      else
        this.Component.Value = new DateTime?();
      return this;
    }

    public TimePickerBuilder Value(TimeSpan? time)
    {
      if (time.HasValue)
        this.Component.Value = new DateTime?(new DateTime(time.Value.Ticks));
      else
        this.Component.Value = new DateTime?();
      return this;
    }

    public TimePickerBuilder Min(TimeSpan value)
    {
      this.Component.Min = new DateTime?(new DateTime(value.Ticks));
      return this;
    }

    public TimePickerBuilder Min(string value)
    {
      this.Component.Min = new DateTime?(DateTime.Parse(value));
      return this;
    }

    public TimePickerBuilder Max(TimeSpan value)
    {
      this.Component.Max = new DateTime?(new DateTime(value.Ticks));
      return this;
    }

    public TimePickerBuilder Max(string value)
    {
      this.Component.Max = new DateTime?(DateTime.Parse(value));
      return this;
    }

    public TimePickerBuilder BindTo(IList<DateTime> dates)
    {
      this.Component.Dates = dates.ToArray<DateTime>();
      return this;
    }

    public TimePickerBuilder ComponentType(string value)
    {
      this.Container.ComponentType = value;
      return this;
    }

    public TimePickerBuilder Culture(string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public TimePickerBuilder DateInput(bool value)
    {
      this.Container.DateInput = new bool?(value);
      return this;
    }

    public TimePickerBuilder DateInput()
    {
      this.Container.DateInput = new bool?(true);
      return this;
    }

    public TimePickerBuilder Dates(params DateTime[] value)
    {
      this.Container.Dates = value;
      return this;
    }

    public TimePickerBuilder Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public TimePickerBuilder Interval(int value)
    {
      this.Container.Interval = new int?(value);
      return this;
    }

    public TimePickerBuilder Max(DateTime value)
    {
      this.Container.Max = new DateTime?(value);
      return this;
    }

    public TimePickerBuilder Min(DateTime value)
    {
      this.Container.Min = new DateTime?(value);
      return this;
    }

    public TimePickerBuilder ParseFormats(params string[] value)
    {
      this.Container.ParseFormats = value;
      return this;
    }

    public TimePickerBuilder Popup(
      Action<TimePickerPopupSettingsBuilder> configurator)
    {
      this.Container.Popup.TimePicker = this.Container;
      configurator(new TimePickerPopupSettingsBuilder(this.Container.Popup));
      return this;
    }

    public TimePickerBuilder Value(DateTime value)
    {
      this.Container.Value = new DateTime?(value);
      return this;
    }

    public TimePickerBuilder Events(Action<TimePickerEventBuilder> configurator)
    {
      configurator(new TimePickerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
