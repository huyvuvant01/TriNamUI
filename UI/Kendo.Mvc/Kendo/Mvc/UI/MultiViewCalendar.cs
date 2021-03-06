// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MultiViewCalendar
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class MultiViewCalendar : WidgetBase
  {
    public MultiViewCalendar(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public string FooterId { get; set; }

    public bool EnableFooter { get; set; } = true;

    public CalendarSelectionSettings SelectionSettings { get; } = new CalendarSelectionSettings();

    public IEnumerable<string> DisableDates { get; set; } = (IEnumerable<string>) new string[0];

    public ClientHandlerDescriptor DisableDatesHandler { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.HtmlAttributes.AppendInValue("class", " ", (object) "k-widget k-calendar");
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void VerifySettings()
    {
      base.VerifySettings();
      DateTime? min = this.Min;
      DateTime? max = this.Max;
      if ((min.HasValue & max.HasValue ? (min.GetValueOrDefault() > max.GetValueOrDefault() ? 1 : 0) : 0) != 0)
        throw new ArgumentException(Exceptions.MinPropertyMustBeLessThenMaxProperty.FormatWith((object) "Min", (object) "Max"));
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string str = "#";
      if (this.IsInClientTemplate)
        str = "\\" + str;
      if (this.EnableFooter)
      {
        if (this.FooterId.HasValue())
          dictionary["footer"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = string.Format("jQuery('{0}{1}').html()", (object) str, (object) this.FooterId)
          };
        else if (this.Footer.HasValue())
          dictionary["footer"] = (object) this.Footer;
      }
      else
        dictionary["footer"] = (object) this.EnableFooter;
      Dictionary<string, object> source = this.MonthTemplate.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["month"] = (object) source;
      if (this.SelectionSettings.Dates.Any<DateTime>())
        dictionary["dates"] = (object) this.SelectionSettings.Dates;
      string url = this.SelectionSettings.GenerateUrl(this.ViewContext, this.UrlGenerator);
      if (url.HasValue())
        dictionary["url"] = (object) url;
      ClientHandlerDescriptor disableDatesHandler = this.DisableDatesHandler;
      if ((disableDatesHandler != null ? (disableDatesHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["disableDates"] = (object) this.DisableDatesHandler;
      else if (this.DisableDates.Any<string>())
        dictionary["disableDates"] = (object) this.DisableDates;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (MultiViewCalendar), (IDictionary<string, object>) dictionary));
    }

    public string Culture { get; set; }

    public DateTime[] Dates { get; set; }

    public string Footer { get; set; }

    public string Format { get; set; }

    public DateTime? Max { get; set; }

    public MultiViewCalendarMessagesSettings Messages { get; } = new MultiViewCalendarMessagesSettings();

    public DateTime? Min { get; set; }

    public double? Views { get; set; }

    public MultiViewCalendarRangeSettings Range { get; } = new MultiViewCalendarRangeSettings();

    public string Selectable { get; set; }

    public DateTime[] SelectDates { get; set; }

    public bool? ShowViewHeader { get; set; }

    public bool? WeekNumber { get; set; }

    public DateTime? Value { get; set; }

    public CalendarView? Start { get; set; }

    public CalendarView? Depth { get; set; }

    public MultiViewCalendarMonthTemplateSettings MonthTemplate { get; } = new MultiViewCalendarMonthTemplateSettings();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["culture"] = (object) this.Culture;
      DateTime[] dates = this.Dates;
      if ((dates != null ? (((IEnumerable<DateTime>) dates).Any<DateTime>() ? 1 : 0) : 0) != 0)
        dictionary1["dates"] = (object) this.Dates;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["format"] = (object) this.Format;
      DateTime? nullable1 = this.Max;
      if (nullable1.HasValue)
        dictionary1["max"] = (object) this.Max;
      Dictionary<string, object> source1 = this.Messages.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["messages"] = (object) source1;
      nullable1 = this.Min;
      if (nullable1.HasValue)
        dictionary1["min"] = (object) this.Min;
      if (this.Views.HasValue)
        dictionary1["views"] = (object) this.Views;
      Dictionary<string, object> source2 = this.Range.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["range"] = (object) source2;
      string selectable = this.Selectable;
      if ((selectable != null ? (selectable.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["selectable"] = (object) this.Selectable;
      DateTime[] selectDates = this.SelectDates;
      if ((selectDates != null ? (((IEnumerable<DateTime>) selectDates).Any<DateTime>() ? 1 : 0) : 0) != 0)
        dictionary1["selectDates"] = (object) this.SelectDates;
      bool? nullable2 = this.ShowViewHeader;
      if (nullable2.HasValue)
        dictionary1["showViewHeader"] = (object) this.ShowViewHeader;
      nullable2 = this.WeekNumber;
      if (nullable2.HasValue)
        dictionary1["weekNumber"] = (object) this.WeekNumber;
      nullable1 = this.Value;
      if (nullable1.HasValue)
        dictionary1["value"] = (object) this.Value;
      CalendarView? nullable3 = this.Start;
      if (nullable3.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        nullable3 = this.Start;
        ref CalendarView? local = ref nullable3;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["start"] = (object) str;
      }
      nullable3 = this.Depth;
      if (nullable3.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        nullable3 = this.Depth;
        ref CalendarView? local = ref nullable3;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["depth"] = (object) str;
      }
      return dictionary1;
    }
  }
}
