// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Timeline`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
  public class Timeline<T> : WidgetBase where T : class
  {
    private readonly TimelineSettingsSerializer<T> settingsSerializer;

    public string DataSourceId { get; set; }

    public DataSource DataSource { get; private set; }

    public string EventTemplate { get; set; }

    public string EventTemplateId { get; set; }

    public Timeline(ViewContext viewContext)
      : base(viewContext)
    {
      this.settingsSerializer = new TimelineSettingsSerializer<T>(this);
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.ModelType(typeof (T));
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      this.settingsSerializer.Serialize((IDictionary<string, object>) dictionary);
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Timeline<T>), (IDictionary<string, object>) dictionary));
    }

    public bool? AutoBind { get; set; }

    public bool? AlternatingMode { get; set; }

    public bool? CollapsibleEvents { get; set; }

    public string DataActionsField { get; set; }

    public string DataDescriptionField { get; set; }

    public string DataDateField { get; set; }

    public string DataImagesAltField { get; set; }

    public string DataImagesField { get; set; }

    public string DataSubtitleField { get; set; }

    public string DataTitleField { get; set; }

    public string DateFormat { get; set; }

    public double? EventHeight { get; set; }

    public double? EventWidth { get; set; }

    public bool? Navigatable { get; set; }

    public bool? ShowDateLabels { get; set; }

    public TimelineOrientation? Orientation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      if (this.AlternatingMode.HasValue)
        dictionary1["alternatingMode"] = (object) this.AlternatingMode;
      if (this.CollapsibleEvents.HasValue)
        dictionary1["collapsibleEvents"] = (object) this.CollapsibleEvents;
      string dataActionsField = this.DataActionsField;
      if ((dataActionsField != null ? (dataActionsField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataActionsField"] = (object) this.DataActionsField;
      string descriptionField = this.DataDescriptionField;
      if ((descriptionField != null ? (descriptionField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataDescriptionField"] = (object) this.DataDescriptionField;
      string dataDateField = this.DataDateField;
      if ((dataDateField != null ? (dataDateField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataDateField"] = (object) this.DataDateField;
      string dataImagesAltField = this.DataImagesAltField;
      if ((dataImagesAltField != null ? (dataImagesAltField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataImagesAltField"] = (object) this.DataImagesAltField;
      string dataImagesField = this.DataImagesField;
      if ((dataImagesField != null ? (dataImagesField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataImagesField"] = (object) this.DataImagesField;
      string dataSubtitleField = this.DataSubtitleField;
      if ((dataSubtitleField != null ? (dataSubtitleField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataSubtitleField"] = (object) this.DataSubtitleField;
      string dataTitleField = this.DataTitleField;
      if ((dataTitleField != null ? (dataTitleField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataTitleField"] = (object) this.DataTitleField;
      string dateFormat = this.DateFormat;
      if ((dateFormat != null ? (dateFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dateFormat"] = (object) this.DateFormat;
      if (this.EventHeight.HasValue)
        dictionary1["eventHeight"] = (object) this.EventHeight;
      if (this.EventWidth.HasValue)
        dictionary1["eventWidth"] = (object) this.EventWidth;
      if (this.Navigatable.HasValue)
        dictionary1["navigatable"] = (object) this.Navigatable;
      if (this.ShowDateLabels.HasValue)
        dictionary1["showDateLabels"] = (object) this.ShowDateLabels;
      if (this.Orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        TimelineOrientation? orientation = this.Orientation;
        ref TimelineOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      return dictionary1;
    }
  }
}
