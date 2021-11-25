// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DateTimePicker
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DateTimePicker : 
    WidgetBase,
    IInputComponent<DateTime>,
    IWidget,
    IHtmlAttributesContainer,
    IFormEditor
  {
    public DateTimePicker(ViewContext viewContext)
      : base(viewContext)
    {
      this.Enabled = true;
      this.Value = new DateTime?();
    }

    public PopupAnimation Animation { get; } = new PopupAnimation();

    public CultureInfo CultureInfo => !this.Culture.HasValue() ? CultureInfo.CurrentCulture : new CultureInfo(this.Culture);

    public IEnumerable<string> DisableDates { get; set; } = (IEnumerable<string>) new string[0];

    public ClientHandlerDescriptor DisableDatesHandler { get; set; }

    public bool Enabled { get; set; }

    public bool EnableFooter { get; set; } = true;

    public string FooterId { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder dateTimeInput = this.Generator.GenerateDateTimeInput(this.ViewContext, this.Explorer ?? ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider), this.Id, this.Name, (object) this.Value, this.Format, this.HtmlAttributes);
      if (!this.Enabled)
        dateTimeInput.MergeAttribute("disabled", "disabled");
      dateTimeInput.TagRenderMode = TagRenderMode.SelfClosing;
      dateTimeInput.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string str = "#";
      if (this.IsInClientTemplate)
        str = "\\" + str;
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Any<KeyValuePair<string, object>>())
        dictionary["animation"] = json["animation"];
      ClientHandlerDescriptor disableDatesHandler = this.DisableDatesHandler;
      if ((disableDatesHandler != null ? (disableDatesHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["disableDates"] = (object) this.DisableDatesHandler;
      else if (this.DisableDates.Any<string>())
        dictionary["disableDates"] = (object) this.DisableDates;
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
      return (IDictionary<string, object>) dictionary;
    }

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (DateTimePicker), this.Serialize()));

    public string ARIATemplate { get; set; }

    public string ARIATemplateId { get; set; }

    public string ComponentType { get; set; }

    public string Culture { get; set; }

    public bool? DateInput { get; set; }

    public DateTime[] Dates { get; set; }

    public string Footer { get; set; }

    public string Format { get; set; }

    public double? Interval { get; set; }

    public DateTime? Max { get; set; }

    public DateTime? Min { get; set; }

    public DateTimePickerPopupSettings Popup { get; } = new DateTimePickerPopupSettings();

    public bool? WeekNumber { get; set; }

    public string[] ParseFormats { get; set; }

    public string TimeFormat { get; set; }

    public DateTime? Value { get; set; }

    public CalendarView? Start { get; set; }

    public CalendarView? Depth { get; set; }

    public DateTimePickerMonthTemplateSettings MonthTemplate { get; } = new DateTimePickerMonthTemplateSettings();

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
      string componentType = this.ComponentType;
      if ((componentType != null ? (componentType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["componentType"] = (object) this.ComponentType;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["culture"] = (object) this.Culture;
      bool? nullable1 = this.DateInput;
      if (nullable1.HasValue)
        dictionary1["dateInput"] = (object) this.DateInput;
      DateTime[] dates = this.Dates;
      if ((dates != null ? (((IEnumerable<DateTime>) dates).Any<DateTime>() ? 1 : 0) : 0) != 0)
        dictionary1["dates"] = (object) this.Dates;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["format"] = (object) this.Format;
      if (this.Interval.HasValue)
        dictionary1["interval"] = (object) this.Interval;
      DateTime? nullable2 = this.Max;
      if (nullable2.HasValue)
        dictionary1["max"] = (object) this.Max;
      nullable2 = this.Min;
      if (nullable2.HasValue)
        dictionary1["min"] = (object) this.Min;
      Dictionary<string, object> source = this.Popup.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["popup"] = (object) source;
      nullable1 = this.WeekNumber;
      if (nullable1.HasValue)
        dictionary1["weekNumber"] = (object) this.WeekNumber;
      string[] parseFormats = this.ParseFormats;
      if ((parseFormats != null ? (((IEnumerable<string>) parseFormats).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary1["parseFormats"] = (object) this.ParseFormats;
      string timeFormat = this.TimeFormat;
      if ((timeFormat != null ? (timeFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["timeFormat"] = (object) this.TimeFormat;
      nullable2 = this.Value;
      if (nullable2.HasValue)
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
