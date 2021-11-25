// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DateRangePicker
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
  public class DateRangePicker : WidgetBase
  {
    public DateRangePicker(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
      if (this.StartField.HasValue() && this.EndField.HasValue())
        tag.MergeAttribute("data-bind", "start:{0}, end:{1}".FormatWith((object) this.StartField, (object) this.EndField));
      tag.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DisableDates != null && this.DisableDates.Count<string>() > 0)
        dictionary["disableDates"] = (object) this.DisableDates;
      else if (this.DisableDatesHandler != null)
        dictionary["disableDates"] = (object) this.DisableDatesHandler;
      Dictionary<string, object> source = this.MonthTemplate.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["month"] = (object) source;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (DateRangePicker), (IDictionary<string, object>) dictionary));
    }

    public override void VerifySettings()
    {
      base.VerifySettings();
      DateTime? min = this.Min;
      DateTime? max = this.Max;
      if ((min.HasValue & max.HasValue ? (min.GetValueOrDefault() > max.GetValueOrDefault() ? 1 : 0) : 0) != 0)
        throw new ArgumentException(Exceptions.MinPropertyMustBeLessThenMaxProperty.FormatWith((object) "Min", (object) "Max"));
    }

    public IEnumerable<string> DisableDates { get; set; }

    public ClientHandlerDescriptor DisableDatesHandler { get; set; }

    public DateRangePickerMonthTemplateSettings MonthTemplate { get; } = new DateRangePickerMonthTemplateSettings();

    public string ARIATemplate { get; set; }

    public string ARIATemplateId { get; set; }

    public string Culture { get; set; }

    public DateTime[] Dates { get; set; }

    public string EndField { get; set; }

    public string Footer { get; set; }

    public string Format { get; set; }

    public DateTime? Max { get; set; }

    public DateRangePickerMessagesSettings Messages { get; } = new DateRangePickerMessagesSettings();

    public DateTime? Min { get; set; }

    public bool? Labels { get; set; }

    public bool? WeekNumber { get; set; }

    public DateRangePickerRangeSettings Range { get; } = new DateRangePickerRangeSettings();

    public string StartField { get; set; }

    public CalendarView? Start { get; set; }

    public CalendarView? Depth { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.ARIATemplateId.HasValue())
        dictionary1["ARIATemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ARIATemplateId)
        };
      else if (this.ARIATemplate.HasValue())
        dictionary1["ARIATemplate"] = (object) this.ARIATemplate;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["culture"] = (object) this.Culture;
      DateTime[] dates = this.Dates;
      if ((dates != null ? (((IEnumerable<DateTime>) dates).Any<DateTime>() ? 1 : 0) : 0) != 0)
        dictionary1["dates"] = (object) this.Dates;
      string endField = this.EndField;
      if ((endField != null ? (endField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["endField"] = (object) this.EndField;
      string footer = this.Footer;
      if ((footer != null ? (footer.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["footer"] = (object) this.Footer;
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
      bool? nullable2 = this.Labels;
      if (nullable2.HasValue)
        dictionary1["labels"] = (object) this.Labels;
      nullable2 = this.WeekNumber;
      if (nullable2.HasValue)
        dictionary1["weekNumber"] = (object) this.WeekNumber;
      Dictionary<string, object> source2 = this.Range.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["range"] = (object) source2;
      string startField = this.StartField;
      if ((startField != null ? (startField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["startField"] = (object) this.StartField;
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
