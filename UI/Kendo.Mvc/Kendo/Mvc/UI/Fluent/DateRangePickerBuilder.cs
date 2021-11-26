// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DateRangePickerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class DateRangePickerBuilder : WidgetBuilderBase<DateRangePicker, DateRangePickerBuilder>
  {
    public DateRangePickerBuilder(DateRangePicker component)
      : base(component)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public DateRangePickerBuilder DisableDates(
      IEnumerable<string> disableDates)
    {
      this.Component.DisableDates = disableDates;
      return this;
    }

    public DateRangePickerBuilder DisableDates(params DayOfWeek[] days)
    {
      this.Component.DisableDates = days.ToAbbrev();
      return this;
    }

    public DateRangePickerBuilder DisableDates(string handler)
    {
      this.Component.DisableDatesHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DateRangePickerBuilder MonthTemplate(
      Action<DateRangePickerMonthTemplateSettingsBuilder> configurator)
    {
      this.Container.MonthTemplate.DateRangePicker = this.Container;
      configurator(new DateRangePickerMonthTemplateSettingsBuilder(this.Container.MonthTemplate));
      return this;
    }

    public DateRangePickerBuilder ARIATemplate(string value)
    {
      this.Container.ARIATemplate = value;
      return this;
    }

    public DateRangePickerBuilder ARIATemplateId(string templateId)
    {
      this.Container.ARIATemplateId = templateId;
      return this;
    }

    public DateRangePickerBuilder Culture(string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public DateRangePickerBuilder Dates(params DateTime[] value)
    {
      this.Container.Dates = value;
      return this;
    }

    public DateRangePickerBuilder EndField(string value)
    {
      this.Container.EndField = value;
      return this;
    }

    public DateRangePickerBuilder Footer(string value)
    {
      this.Container.Footer = value;
      return this;
    }

    public DateRangePickerBuilder Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public DateRangePickerBuilder Max(DateTime value)
    {
      this.Container.Max = new DateTime?(value);
      return this;
    }

    public DateRangePickerBuilder Messages(
      Action<DateRangePickerMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.DateRangePicker = this.Container;
      configurator(new DateRangePickerMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public DateRangePickerBuilder Min(DateTime value)
    {
      this.Container.Min = new DateTime?(value);
      return this;
    }

    public DateRangePickerBuilder Labels(bool value)
    {
      this.Container.Labels = new bool?(value);
      return this;
    }

    public DateRangePickerBuilder WeekNumber(bool value)
    {
      this.Container.WeekNumber = new bool?(value);
      return this;
    }

    public DateRangePickerBuilder WeekNumber()
    {
      this.Container.WeekNumber = new bool?(true);
      return this;
    }

    public DateRangePickerBuilder Range(
      Action<DateRangePickerRangeSettingsBuilder> configurator)
    {
      this.Container.Range.DateRangePicker = this.Container;
      configurator(new DateRangePickerRangeSettingsBuilder(this.Container.Range));
      return this;
    }

    public DateRangePickerBuilder StartField(string value)
    {
      this.Container.StartField = value;
      return this;
    }

    public DateRangePickerBuilder Start(CalendarView value)
    {
      this.Container.Start = new CalendarView?(value);
      return this;
    }

    public DateRangePickerBuilder Depth(CalendarView value)
    {
      this.Container.Depth = new CalendarView?(value);
      return this;
    }

    public DateRangePickerBuilder Events(
      Action<DateRangePickerEventBuilder> configurator)
    {
      configurator(new DateRangePickerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
