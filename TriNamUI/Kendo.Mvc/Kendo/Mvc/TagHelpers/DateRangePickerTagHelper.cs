// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DateRangePickerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-daterangepicker")]
  [RestrictChildren("messages", new string[] {"month", "range"})]
  [OutputElementHint("div")]
  public class DateRangePickerTagHelper : TagHelperBase
  {
    public DateRangePickerTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DateRangePickerTagHelper rangePickerTagHelper = this;
      context.Items[(object) rangePickerTagHelper.GetType()] = (object) rangePickerTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await rangePickerTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "DateRangePicker", (IDictionary<string, object>) this.SerializeSettings());

    public string OnChange { get; set; }

    public string OnClose { get; set; }

    public string OnOpen { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onClose = this.OnClose;
      if ((onClose != null ? (onClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.OnClose);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      return dictionary;
    }

    public string ARIATemplate { get; set; }

    public string ARIATemplateId { get; set; }

    public string Culture { get; set; }

    public DateTime[] Dates { get; set; }

    public CalendarView? Depth { get; set; }

    public DateTime[] DisableDates { get; set; }

    public string EndField { get; set; }

    public string Footer { get; set; }

    public string FooterHandler { get; set; }

    public string Format { get; set; }

    public DateTime? Max { get; set; }

    [HtmlAttributeNotBound]
    public DateRangePickerMessagesSettingsTagHelper Messages { get; set; }

    public DateTime? Min { get; set; }

    [HtmlAttributeNotBound]
    public DateRangePickerMonthSettingsTagHelper Month { get; set; }

    public bool? Labels { get; set; }

    public bool? WeekNumber { get; set; }

    [HtmlAttributeNotBound]
    public DateRangePickerRangeSettingsTagHelper Range { get; set; }

    public CalendarView? Start { get; set; }

    public string StartField { get; set; }

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
      CalendarView? nullable1 = this.Depth;
      if (nullable1.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        nullable1 = this.Depth;
        ref CalendarView? local = ref nullable1;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["depth"] = (object) str;
      }
      DateTime[] disableDates = this.DisableDates;
      if ((disableDates != null ? (((IEnumerable<DateTime>) disableDates).Any<DateTime>() ? 1 : 0) : 0) != 0)
        dictionary1["disableDates"] = (object) this.DisableDates;
      string endField = this.EndField;
      if ((endField != null ? (endField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["endField"] = (object) this.EndField;
      string footerHandler = this.FooterHandler;
      if ((footerHandler != null ? (footerHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["footer"] = (object) this.CreateHandler(this.FooterHandler);
      }
      else
      {
        string footer = this.Footer;
        if ((footer != null ? (footer.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["footer"] = (object) this.Footer;
      }
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["format"] = (object) this.Format;
      DateTime? nullable2 = this.Max;
      if (nullable2.HasValue)
        dictionary1["max"] = (object) this.Max;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["messages"] = (object) source;
      }
      nullable2 = this.Min;
      if (nullable2.HasValue)
        dictionary1["min"] = (object) this.Min;
      if (this.Month != null)
      {
        Dictionary<string, object> source = this.Month.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["month"] = (object) source;
      }
      bool? nullable3 = this.Labels;
      if (nullable3.HasValue)
        dictionary1["labels"] = (object) this.Labels;
      nullable3 = this.WeekNumber;
      if (nullable3.HasValue)
        dictionary1["weekNumber"] = (object) this.WeekNumber;
      if (this.Range != null)
      {
        Dictionary<string, object> source = this.Range.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["range"] = (object) source;
      }
      nullable1 = this.Start;
      if (nullable1.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        nullable1 = this.Start;
        ref CalendarView? local = ref nullable1;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["start"] = (object) str;
      }
      string startField = this.StartField;
      if ((startField != null ? (startField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["startField"] = (object) this.StartField;
      return dictionary1;
    }
  }
}
