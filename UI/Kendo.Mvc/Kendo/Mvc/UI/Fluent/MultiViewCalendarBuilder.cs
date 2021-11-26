// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MultiViewCalendarBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class MultiViewCalendarBuilder : 
    WidgetBuilderBase<MultiViewCalendar, MultiViewCalendarBuilder>
  {
    public MultiViewCalendarBuilder(MultiViewCalendar component)
      : base(component)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public MultiViewCalendarBuilder DisableDates(
      IEnumerable<string> disableDates)
    {
      this.Component.DisableDates = disableDates;
      return this;
    }

    public MultiViewCalendarBuilder DisableDates(params DayOfWeek[] days)
    {
      this.Component.DisableDates = days.ToAbbrev();
      return this;
    }

    public MultiViewCalendarBuilder DisableDates(string handler)
    {
      this.Component.DisableDatesHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public MultiViewCalendarBuilder FooterId(string id)
    {
      this.Component.FooterId = id;
      return this;
    }

    public MultiViewCalendarBuilder MonthTemplateId(string id)
    {
      this.Component.MonthTemplate.ContentId = id;
      this.Component.MonthTemplate.MultiViewCalendar = this.Component;
      return this;
    }

    public MultiViewCalendarBuilder MonthTemplate(string content)
    {
      this.Component.MonthTemplate.Content = content;
      this.Component.MonthTemplate.MultiViewCalendar = this.Component;
      return this;
    }

    public MultiViewCalendarBuilder Culture(string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public MultiViewCalendarBuilder Dates(params DateTime[] value)
    {
      this.Container.Dates = value;
      return this;
    }

    public MultiViewCalendarBuilder Footer(string value)
    {
      this.Container.Footer = value;
      return this;
    }

    public MultiViewCalendarBuilder Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public MultiViewCalendarBuilder Max(DateTime value)
    {
      this.Container.Max = new DateTime?(value);
      return this;
    }

    public MultiViewCalendarBuilder Messages(
      Action<MultiViewCalendarMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.MultiViewCalendar = this.Container;
      configurator(new MultiViewCalendarMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public MultiViewCalendarBuilder Min(DateTime value)
    {
      this.Container.Min = new DateTime?(value);
      return this;
    }

    public MultiViewCalendarBuilder Views(double value)
    {
      this.Container.Views = new double?(value);
      return this;
    }

    public MultiViewCalendarBuilder Range(
      Action<MultiViewCalendarRangeSettingsBuilder> configurator)
    {
      this.Container.Range.MultiViewCalendar = this.Container;
      configurator(new MultiViewCalendarRangeSettingsBuilder(this.Container.Range));
      return this;
    }

    public MultiViewCalendarBuilder Selectable(string value)
    {
      this.Container.Selectable = value;
      return this;
    }

    public MultiViewCalendarBuilder SelectDates(params DateTime[] value)
    {
      this.Container.SelectDates = value;
      return this;
    }

    public MultiViewCalendarBuilder ShowViewHeader(bool value)
    {
      this.Container.ShowViewHeader = new bool?(value);
      return this;
    }

    public MultiViewCalendarBuilder ShowViewHeader()
    {
      this.Container.ShowViewHeader = new bool?(true);
      return this;
    }

    public MultiViewCalendarBuilder WeekNumber(bool value)
    {
      this.Container.WeekNumber = new bool?(value);
      return this;
    }

    public MultiViewCalendarBuilder WeekNumber()
    {
      this.Container.WeekNumber = new bool?(true);
      return this;
    }

    public MultiViewCalendarBuilder Value(DateTime value)
    {
      this.Container.Value = new DateTime?(value);
      return this;
    }

    public MultiViewCalendarBuilder Start(CalendarView value)
    {
      this.Container.Start = new CalendarView?(value);
      return this;
    }

    public MultiViewCalendarBuilder Depth(CalendarView value)
    {
      this.Container.Depth = new CalendarView?(value);
      return this;
    }

    public MultiViewCalendarBuilder MonthTemplate(
      Action<MultiViewCalendarMonthTemplateSettingsBuilder> configurator)
    {
      this.Container.MonthTemplate.MultiViewCalendar = this.Container;
      configurator(new MultiViewCalendarMonthTemplateSettingsBuilder(this.Container.MonthTemplate));
      return this;
    }

    public MultiViewCalendarBuilder Events(
      Action<MultiViewCalendarEventBuilder> configurator)
    {
      configurator(new MultiViewCalendarEventBuilder(this.Container.Events));
      return this;
    }
  }
}
