// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TimePicker
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
  public class TimePicker : WidgetBase, IFormEditor
  {
    public TimePicker(ViewContext viewContext)
      : base(viewContext)
    {
      this.Animation = new PopupAnimation();
      this.Enabled = true;
    }

    public bool Enabled { get; set; }

    public PopupAnimation Animation { get; private set; }

    public CultureInfo CultureInfo => !this.Culture.HasValue() ? CultureInfo.CurrentCulture : new CultureInfo(this.Culture);

    public override void ProcessSettings()
    {
      if (string.IsNullOrEmpty(this.Format))
        this.Format = this.CultureInfo.DateTimeFormat.ShortTimePattern;
      base.ProcessSettings();
    }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder timeInput = this.Generator.GenerateTimeInput(this.ViewContext, this.Explorer ?? ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider), this.Id, this.Name, (object) this.Value, this.Format, this.HtmlAttributes);
      if (!this.Enabled)
        timeInput.MergeAttribute("disabled", "disabled");
      timeInput.TagRenderMode = TagRenderMode.SelfClosing;
      timeInput.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Keys.Any<string>())
        dictionary["animation"] = json["animation"];
      return (IDictionary<string, object>) dictionary;
    }

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (TimePicker), this.Serialize()));

    public string ComponentType { get; set; }

    public string Culture { get; set; }

    public bool? DateInput { get; set; }

    public DateTime[] Dates { get; set; }

    public string Format { get; set; }

    public int? Interval { get; set; }

    public DateTime? Max { get; set; }

    public DateTime? Min { get; set; }

    public string[] ParseFormats { get; set; }

    public TimePickerPopupSettings Popup { get; } = new TimePickerPopupSettings();

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
      DateTime[] dates = this.Dates;
      if ((dates != null ? (((IEnumerable<DateTime>) dates).Any<DateTime>() ? 1 : 0) : 0) != 0)
        dictionary["dates"] = (object) this.Dates;
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
      Dictionary<string, object> source = this.Popup.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["popup"] = (object) source;
      nullable = this.Value;
      if (nullable.HasValue)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
