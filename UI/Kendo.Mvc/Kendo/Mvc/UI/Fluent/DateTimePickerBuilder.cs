// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DateTimePickerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
  public class DateTimePickerBuilder : WidgetBuilderBase<DateTimePicker, DateTimePickerBuilder>
  {
    public DateTimePickerBuilder(DateTimePicker component)
      : base(component)
    {
    }

    public DateTimePickerBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public DateTimePickerBuilder Animation(
      Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public DateTimePickerBuilder BindTo(IEnumerable<DateTime> dates)
    {
      this.Component.Dates = dates.ToArray<DateTime>();
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public DateTimePickerBuilder DisableDates(IEnumerable<string> disableDates)
    {
      this.Component.DisableDates = disableDates;
      return this;
    }

    public DateTimePickerBuilder DisableDates(params DayOfWeek[] days)
    {
      this.Component.DisableDates = days.ToAbbrev();
      return this;
    }

    public DateTimePickerBuilder DisableDates(string handler)
    {
      this.Component.DisableDatesHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DateTimePickerBuilder Value(string date)
    {
      DateTime result;
      if (DateTime.TryParse(date, out result))
        this.Component.Value = new DateTime?(result);
      else
        this.Component.Value = new DateTime?();
      return this;
    }

    public DateTimePickerBuilder Value(DateTime? value)
    {
      this.Component.Value = value;
      return this;
    }

    public DateTimePickerBuilder Enable(bool value)
    {
      this.Component.Enabled = value;
      return this;
    }

    public DateTimePickerBuilder Footer(bool footer)
    {
      this.Component.EnableFooter = footer;
      return this;
    }

    public DateTimePickerBuilder FooterId(string id)
    {
      this.Component.FooterId = id;
      return this;
    }

    public DateTimePickerBuilder Min(string date)
    {
      DateTime result;
      if (!DateTime.TryParse(date, out result))
        throw new ArgumentException(Exceptions.StringNotCorrectDate);
      this.Component.Min = new DateTime?(result);
      return this;
    }

    public DateTimePickerBuilder Max(string date)
    {
      DateTime result;
      if (!DateTime.TryParse(date, out result))
        throw new ArgumentException(Exceptions.StringNotCorrectDate);
      this.Component.Max = new DateTime?(result);
      return this;
    }

    public DateTimePickerBuilder MonthTemplateId(string id)
    {
      this.Component.MonthTemplate.ContentId = id;
      return this;
    }

    public DateTimePickerBuilder MonthTemplate(string content)
    {
      this.Component.MonthTemplate.Content = content;
      return this;
    }

    public DateTimePickerBuilder ARIATemplate(string value)
    {
      this.Container.ARIATemplate = value;
      return this;
    }

    public DateTimePickerBuilder ARIATemplateId(string templateId)
    {
      this.Container.ARIATemplateId = templateId;
      return this;
    }

    public DateTimePickerBuilder ComponentType(string value)
    {
      this.Container.ComponentType = value;
      return this;
    }

    public DateTimePickerBuilder Culture(string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public DateTimePickerBuilder DateInput(bool value)
    {
      this.Container.DateInput = new bool?(value);
      return this;
    }

    public DateTimePickerBuilder DateInput()
    {
      this.Container.DateInput = new bool?(true);
      return this;
    }

    public DateTimePickerBuilder Dates(params DateTime[] value)
    {
      this.Container.Dates = value;
      return this;
    }

    public DateTimePickerBuilder Footer(string value)
    {
      this.Container.Footer = value;
      return this;
    }

    public DateTimePickerBuilder Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public DateTimePickerBuilder Interval(double value)
    {
      this.Container.Interval = new double?(value);
      return this;
    }

    public DateTimePickerBuilder Max(DateTime value)
    {
      this.Container.Max = new DateTime?(value);
      return this;
    }

    public DateTimePickerBuilder Min(DateTime value)
    {
      this.Container.Min = new DateTime?(value);
      return this;
    }

    public DateTimePickerBuilder Popup(
      Action<DateTimePickerPopupSettingsBuilder> configurator)
    {
      this.Container.Popup.DateTimePicker = this.Container;
      configurator(new DateTimePickerPopupSettingsBuilder(this.Container.Popup));
      return this;
    }

    public DateTimePickerBuilder WeekNumber(bool value)
    {
      this.Container.WeekNumber = new bool?(value);
      return this;
    }

    public DateTimePickerBuilder WeekNumber()
    {
      this.Container.WeekNumber = new bool?(true);
      return this;
    }

    public DateTimePickerBuilder ParseFormats(params string[] value)
    {
      this.Container.ParseFormats = value;
      return this;
    }

    public DateTimePickerBuilder TimeFormat(string value)
    {
      this.Container.TimeFormat = value;
      return this;
    }

    public DateTimePickerBuilder Value(DateTime value)
    {
      this.Container.Value = new DateTime?(value);
      return this;
    }

    public DateTimePickerBuilder Start(CalendarView value)
    {
      this.Container.Start = new CalendarView?(value);
      return this;
    }

    public DateTimePickerBuilder Depth(CalendarView value)
    {
      this.Container.Depth = new CalendarView?(value);
      return this;
    }

    public DateTimePickerBuilder MonthTemplate(
      Action<DateTimePickerMonthTemplateSettingsBuilder> configurator)
    {
      this.Container.MonthTemplate.DateTimePicker = this.Container;
      configurator(new DateTimePickerMonthTemplateSettingsBuilder(this.Container.MonthTemplate));
      return this;
    }

    public DateTimePickerBuilder Events(
      Action<DateTimePickerEventBuilder> configurator)
    {
      configurator(new DateTimePickerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
