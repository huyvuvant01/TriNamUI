// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TimePickerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
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
  [HtmlTargetElement("kendo-timepicker")]
  [HtmlTargetElement("timepicker-editor", ParentTag = "form-item")]
  [OutputElementHint("input")]
  public class TimePickerTagHelper : TagHelperBase, IKendoFormEditor
  {
    public 
    #nullable disable
    ModelExpression For { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public TimePickerTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
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
      TagBuilder timeInput = this.Generator.GenerateTimeInput(this.ViewContext, modelExplorer, this.Id, this.Name, (object) this.Value, this.Format, (IDictionary<string, object>) dictionary);
      output.TagName = "input";
      output.TagMode = TagMode.SelfClosing;
      output.MergeAttributes(timeInput);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "TimePicker", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "TimePicker";
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

    public string ComponentType { get; set; }

    public string Culture { get; set; }

    public bool? DateInput { get; set; }

    public string Format { get; set; }

    public int? Interval { get; set; }

    public DateTime? Max { get; set; }

    public DateTime? Min { get; set; }

    public string[] ParseFormats { get; set; }

    [HtmlAttributeNotBound]
    public TimePickerPopupSettingsTagHelper Popup { get; set; }

    public DateTime? Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      string componentType = this.ComponentType;
      if ((componentType != null ? (componentType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["componentType"] = (object) this.ComponentType;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["culture"] = (object) this.Culture;
      if (this.DateInput.HasValue)
        dictionary["dateInput"] = (object) this.DateInput;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      if (this.Interval.HasValue)
        dictionary["interval"] = (object) this.Interval;
      DateTime? nullable = this.Max;
      if (nullable.HasValue)
        dictionary["max"] = (object) this.Max;
      nullable = this.Min;
      if (nullable.HasValue)
        dictionary["min"] = (object) this.Min;
      string[] parseFormats = this.ParseFormats;
      if ((parseFormats != null ? (((IEnumerable<string>) parseFormats).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary["parseFormats"] = (object) this.ParseFormats;
      if (this.Popup != null)
      {
        Dictionary<string, object> source = this.Popup.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["popup"] = (object) source;
      }
      nullable = this.Value;
      if (nullable.HasValue)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
