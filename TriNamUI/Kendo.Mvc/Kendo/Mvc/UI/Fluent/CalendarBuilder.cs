// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CalendarBuilder
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
  public class CalendarBuilder : WidgetBuilderBase<Calendar, CalendarBuilder>
  {
    public CalendarBuilder(Calendar component)
      : base(component)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public CalendarBuilder DisableDates(IEnumerable<string> disableDates)
    {
      this.Component.DisableDates = disableDates;
      return this;
    }

    public CalendarBuilder DisableDates(params DayOfWeek[] days)
    {
      this.Component.DisableDates = days.ToAbbrev();
      return this;
    }

    public CalendarBuilder DisableDates(string handler)
    {
      this.Component.DisableDatesHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public CalendarBuilder FooterId(string id)
    {
      this.Component.FooterId = id;
      return this;
    }

    public CalendarBuilder Footer(bool footer)
    {
      this.Component.EnableFooter = footer;
      return this;
    }

    public CalendarBuilder MonthTemplateId(string id)
    {
      this.Component.MonthTemplate.ContentId = id;
      return this;
    }

    public CalendarBuilder MonthTemplate(string content)
    {
      this.Component.MonthTemplate.Content = content;
      return this;
    }

    public CalendarBuilder Min(string date)
    {
      DateTime result;
      if (!DateTime.TryParse(date, out result))
        throw new ArgumentException(Exceptions.StringNotCorrectDate);
      this.Component.Min = new DateTime?(result);
      return this;
    }

    public CalendarBuilder Max(string date)
    {
      DateTime result;
      if (!DateTime.TryParse(date, out result))
        throw new ArgumentException(Exceptions.StringNotCorrectDate);
      this.Component.Max = new DateTime?(result);
      return this;
    }

    public CalendarBuilder Value(DateTime? date)
    {
      this.Component.Value = date;
      return this;
    }

    public CalendarBuilder Value(string date)
    {
      DateTime result;
      if (DateTime.TryParse(date, out result))
        this.Component.Value = new DateTime?(result);
      else
        this.Component.Value = new DateTime?();
      return this;
    }

    public CalendarBuilder Selection(
      Action<CalendarSelectionSettingsBuilder> selectionAction)
    {
      selectionAction(new CalendarSelectionSettingsBuilder(this.Component.SelectionSettings));
      return this;
    }

    public CalendarBuilder ComponentType(string value)
    {
      this.Container.ComponentType = value;
      return this;
    }

    public CalendarBuilder Culture(string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public CalendarBuilder Dates(params DateTime[] value)
    {
      this.Container.Dates = value;
      return this;
    }

    public CalendarBuilder Footer(string value)
    {
      this.Container.Footer = value;
      return this;
    }

    public CalendarBuilder Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public CalendarBuilder Max(DateTime value)
    {
      this.Container.Max = new DateTime?(value);
      return this;
    }

    public CalendarBuilder Messages(
      Action<CalendarMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Calendar = this.Container;
      configurator(new CalendarMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public CalendarBuilder Min(DateTime value)
    {
      this.Container.Min = new DateTime?(value);
      return this;
    }

    public CalendarBuilder Selectable(string value)
    {
      this.Container.Selectable = value;
      return this;
    }

    public CalendarBuilder SelectDates(params DateTime[] value)
    {
      this.Container.SelectDates = value;
      return this;
    }

    public CalendarBuilder WeekNumber(bool value)
    {
      this.Container.WeekNumber = new bool?(value);
      return this;
    }

    public CalendarBuilder WeekNumber()
    {
      this.Container.WeekNumber = new bool?(true);
      return this;
    }

    public CalendarBuilder Value(DateTime value)
    {
      this.Container.Value = new DateTime?(value);
      return this;
    }

    public CalendarBuilder Start(CalendarView value)
    {
      this.Container.Start = new CalendarView?(value);
      return this;
    }

    public CalendarBuilder Depth(CalendarView value)
    {
      this.Container.Depth = new CalendarView?(value);
      return this;
    }

    public CalendarBuilder MonthTemplate(
      Action<CalendarMonthTemplateSettingsBuilder> configurator)
    {
      this.Container.MonthTemplate.Calendar = this.Container;
      configurator(new CalendarMonthTemplateSettingsBuilder(this.Container.MonthTemplate));
      return this;
    }

    public CalendarBuilder Events(Action<CalendarEventBuilder> configurator)
    {
      configurator(new CalendarEventBuilder(this.Container.Events));
      return this;
    }
  }
}
