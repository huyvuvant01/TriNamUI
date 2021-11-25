// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DateTimePickerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-datetimepicker")]
  [HtmlTargetElement("datetimepicker-editor", ParentTag = "form-item")]
  [OutputElementHint("input")]
  public class DateTimePickerTagHelper : TagHelperBase, IKendoFormEditor
  {
    public 
    #nullable disable
    ModelExpression For { get; set; }

    public string MonthTemplateId { get; set; }

    public string MonthTemplate { get; set; }

    public DateTimePickerTagHelper rootTagHelper { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public DateTimePickerTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
      this.rootTagHelper = this;
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      if (this.TryAddToForm(context))
        output.SuppressOutput();
      await base.ProcessAsync(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      ModelExplorer modelExplorer = (ModelExplorer) null;
      if (this.For != null)
      {
        modelExplorer = this.For.ModelExplorer;
        ModelMetadata metadata = this.For.Metadata;
        this.Name = this.For.Name;
        DateTime? nullable = this.Value;
        this.Value = nullable ?? this.For.Model as DateTime?;
        this.Format = this.Format ?? this.ExtractEditFormat(this.For.ModelExplorer.Metadata.EditFormatString);
        nullable = this.Min;
        this.Min = nullable ?? this.GetRangeValidationParameter<DateTime>(modelExplorer, "min");
        nullable = this.Max;
        this.Max = nullable ?? this.GetRangeValidationParameter<DateTime>(modelExplorer, "max");
      }
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      TagBuilder dateTimeInput = this.Generator.GenerateDateTimeInput(this.ViewContext, modelExplorer, this.Id, this.Name, (object) this.Value, this.Format, (IDictionary<string, object>) dictionary);
      output.TagName = "input";
      output.TagMode = TagMode.SelfClosing;
      output.MergeAttributes(dateTimeInput);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "DateTimePicker", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string monthTemplateId = this.MonthTemplateId;
      if ((monthTemplateId != null ? (monthTemplateId.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["month"] = (object) new
        {
          content = new ClientHandlerDescriptor()
          {
            HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.MonthTemplateId)
          }
        };
      }
      else
      {
        string monthTemplate = this.MonthTemplate;
        if ((monthTemplate != null ? (monthTemplate.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["month"] = (object) new
          {
            content = this.MonthTemplate
          };
      }
      return dictionary;
    }

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "DateTimePicker";
          return true;
        }
      }
      return false;
    }

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

    [HtmlAttributeName("ariatemplate")]
    public string ARIATemplate { get; set; }

    [HtmlAttributeName("ariatemplate-id")]
    public string ARIATemplateId { get; set; }

    public string ComponentType { get; set; }

    public string Culture { get; set; }

    public bool? DateInput { get; set; }

    public string Footer { get; set; }

    public string Format { get; set; }

    public double? Interval { get; set; }

    public DateTime? Max { get; set; }

    public DateTime? Min { get; set; }

    [HtmlAttributeNotBound]
    public DateTimePickerPopupSettingsTagHelper Popup { get; set; }

    public bool? WeekNumber { get; set; }

    public string[] ParseFormats { get; set; }

    public string TimeFormat { get; set; }

    public DateTime? Value { get; set; }

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
      string componentType = this.ComponentType;
      if ((componentType != null ? (componentType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["componentType"] = (object) this.ComponentType;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["culture"] = (object) this.Culture;
      bool? nullable1 = this.DateInput;
      if (nullable1.HasValue)
        dictionary1["dateInput"] = (object) this.DateInput;
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
      if (this.Popup != null)
      {
        Dictionary<string, object> source = this.Popup.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["popup"] = (object) source;
      }
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
