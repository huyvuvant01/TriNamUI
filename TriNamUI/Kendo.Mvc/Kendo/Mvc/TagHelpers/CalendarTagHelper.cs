﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.CalendarTagHelper
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
  [HtmlTargetElement("kendo-calendar")]
  [RestrictChildren("messages", new string[] {"month"})]
  public class CalendarTagHelper : TagHelperBase
  {
    public CalendarTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      CalendarTagHelper calendarTagHelper = this;
      context.Items[(object) calendarTagHelper.GetType()] = (object) calendarTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await calendarTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DisableDates == null && this.DisableDatesHandler.HasValue())
        dictionary["disableDates"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.DisableDatesHandler
        };
      string footer = this.Footer;
      if ((footer != null ? (footer.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["footer"] = (object) this.Footer;
      }
      else
      {
        string footerHandler = this.FooterHandler;
        if ((footerHandler != null ? (footerHandler.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["footer"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = this.FooterHandler
          };
      }
      return this.Initializer.Initialize(this.Selector, "Calendar", (IDictionary<string, object>) dictionary);
    }

    public string DisableDatesHandler { get; set; }

    public string OnChange { get; set; }

    public string OnNavigate { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onNavigate = this.OnNavigate;
      if ((onNavigate != null ? (onNavigate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["navigate"] = (object) this.CreateHandler(this.OnNavigate);
      return dictionary;
    }

    public string ComponentType { get; set; }

    public string Culture { get; set; }

    public DateTime[] Dates { get; set; }

    public CalendarView? Depth { get; set; }

    public DateTime[] DisableDates { get; set; }

    public string Footer { get; set; }

    public string FooterHandler { get; set; }

    public string Format { get; set; }

    public DateTime? Max { get; set; }

    [HtmlAttributeNotBound]
    public CalendarMessagesSettingsTagHelper Messages { get; set; }

    public DateTime? Min { get; set; }

    [HtmlAttributeNotBound]
    public CalendarMonthSettingsTagHelper Month { get; set; }

    public string Selectable { get; set; }

    public DateTime[] SelectDates { get; set; }

    public bool? WeekNumber { get; set; }

    public CalendarView? Start { get; set; }

    public DateTime? Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      string componentType = this.ComponentType;
      if ((componentType != null ? (componentType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["componentType"] = (object) this.ComponentType;
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
      string selectable = this.Selectable;
      if ((selectable != null ? (selectable.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["selectable"] = (object) this.Selectable;
      DateTime[] selectDates = this.SelectDates;
      if ((selectDates != null ? (((IEnumerable<DateTime>) selectDates).Any<DateTime>() ? 1 : 0) : 0) != 0)
        dictionary1["selectDates"] = (object) this.SelectDates;
      if (this.WeekNumber.HasValue)
        dictionary1["weekNumber"] = (object) this.WeekNumber;
      nullable1 = this.Start;
      if (nullable1.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        nullable1 = this.Start;
        ref CalendarView? local = ref nullable1;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["start"] = (object) str;
      }
      nullable2 = this.Value;
      if (nullable2.HasValue)
        dictionary1["value"] = (object) this.Value;
      return dictionary1;
    }
  }
}
