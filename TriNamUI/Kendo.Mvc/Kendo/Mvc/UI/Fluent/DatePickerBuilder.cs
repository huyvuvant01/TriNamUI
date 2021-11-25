// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DatePickerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class DatePickerBuilder : WidgetBuilderBase<DatePicker, DatePickerBuilder>
  {
    public DatePickerBuilder(DatePicker component)
      : base(component)
    {
    }

    public DatePickerBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public DatePickerBuilder Animation(
      Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public DatePickerBuilder DisableDates(IEnumerable<string> disableDates)
    {
      this.Component.DisableDates = disableDates;
      return this;
    }

    public DatePickerBuilder DisableDates(params DayOfWeek[] days)
    {
      this.Component.DisableDates = days.ToAbbrev();
      return this;
    }

    public DatePickerBuilder DisableDates(string handler)
    {
      this.Component.DisableDatesHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DatePickerBuilder Enable(bool value)
    {
      this.Component.Enabled = value;
      return this;
    }

    public DatePickerBuilder Value(string date)
    {
      DateTime result;
      if (DateTime.TryParse(date, out result))
        this.Component.Value = new DateTime?(result);
      else
        this.Component.Value = new DateTime?();
      return this;
    }

    public DatePickerBuilder Value(DateTime? date)
    {
      this.Component.Value = date;
      return this;
    }

    public DatePickerBuilder BindTo(List<DateTime> dates)
    {
      this.Component.Dates = dates.ToArray();
      return this;
    }

    public DatePickerBuilder FooterId(string id)
    {
      this.Component.FooterId = id;
      return this;
    }

    public DatePickerBuilder Footer(bool footer)
    {
      this.Component.EnableFooter = footer;
      return this;
    }

    public DatePickerBuilder MonthTemplateId(string id)
    {
      this.Component.MonthTemplate.ContentId = id;
      return this;
    }

    public DatePickerBuilder MonthTemplate(string content)
    {
      this.Component.MonthTemplate.Content = content;
      return this;
    }

    public DatePickerBuilder Min(string date)
    {
      DateTime result;
      if (!DateTime.TryParse(date, out result))
        throw new ArgumentException(Exceptions.StringNotCorrectDate);
      this.Component.Min = new DateTime?(result);
      return this;
    }

    public DatePickerBuilder Max(string date)
    {
      DateTime result;
      if (!DateTime.TryParse(date, out result))
        throw new ArgumentException(Exceptions.StringNotCorrectDate);
      this.Component.Max = new DateTime?(result);
      return this;
    }

    public DatePickerBuilder ARIATemplate(string value)
    {
      this.Container.ARIATemplate = value;
      return this;
    }

    public DatePickerBuilder ARIATemplateId(string templateId)
    {
      this.Container.ARIATemplateId = templateId;
      return this;
    }

    public DatePickerBuilder ComponentType(string value)
    {
      this.Container.ComponentType = value;
      return this;
    }

    public DatePickerBuilder Culture(string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public DatePickerBuilder DateInput(bool value)
    {
      this.Container.DateInput = new bool?(value);
      return this;
    }

    public DatePickerBuilder DateInput()
    {
      this.Container.DateInput = new bool?(true);
      return this;
    }

    public DatePickerBuilder Dates(params DateTime[] value)
    {
      this.Container.Dates = value;
      return this;
    }

    public DatePickerBuilder Footer(string value)
    {
      this.Container.Footer = value;
      return this;
    }

    public DatePickerBuilder Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public DatePickerBuilder Max(DateTime value)
    {
      this.Container.Max = new DateTime?(value);
      return this;
    }

    public DatePickerBuilder Min(DateTime value)
    {
      this.Container.Min = new DateTime?(value);
      return this;
    }

    public DatePickerBuilder Popup(
      Action<DatePickerPopupSettingsBuilder> configurator)
    {
      this.Container.Popup.DatePicker = this.Container;
      configurator(new DatePickerPopupSettingsBuilder(this.Container.Popup));
      return this;
    }

    public DatePickerBuilder WeekNumber(bool value)
    {
      this.Container.WeekNumber = new bool?(value);
      return this;
    }

    public DatePickerBuilder WeekNumber()
    {
      this.Container.WeekNumber = new bool?(true);
      return this;
    }

    public DatePickerBuilder ParseFormats(params string[] value)
    {
      this.Container.ParseFormats = value;
      return this;
    }

    public DatePickerBuilder Value(DateTime value)
    {
      this.Container.Value = new DateTime?(value);
      return this;
    }

    public DatePickerBuilder Start(CalendarView value)
    {
      this.Container.Start = new CalendarView?(value);
      return this;
    }

    public DatePickerBuilder Depth(CalendarView value)
    {
      this.Container.Depth = new CalendarView?(value);
      return this;
    }

    public DatePickerBuilder MonthTemplate(
      Action<DatePickerMonthTemplateSettingsBuilder> configurator)
    {
      this.Container.MonthTemplate.DatePicker = this.Container;
      configurator(new DatePickerMonthTemplateSettingsBuilder(this.Container.MonthTemplate));
      return this;
    }

    public DatePickerBuilder Events(Action<DatePickerEventBuilder> configurator)
    {
      configurator(new DatePickerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
