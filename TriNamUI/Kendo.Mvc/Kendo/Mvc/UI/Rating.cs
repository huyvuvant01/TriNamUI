// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Rating
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Rating : WidgetBase, IFormEditor
  {
    public Rating(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateNumericInput(this.ViewContext, this.Explorer, this.Id, this.Name, (object) this.Value, (string) null, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize() => (IDictionary<string, object>) this.SerializeSettings();

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (Rating), this.Serialize()));

    public double? Min { get; set; }

    public double? Max { get; set; }

    public string Selection { get; set; }

    public string Precision { get; set; }

    public bool? Tooltip { get; set; }

    public RatingLabelSettings Label { get; } = new RatingLabelSettings();

    public double? SelectValueOnFocus { get; set; }

    public string ItemTemplate { get; set; }

    public string ItemTemplateId { get; set; }

    public string SelectedTemplate { get; set; }

    public string SelectedTemplateId { get; set; }

    public string HoveredTemplate { get; set; }

    public string HoveredTemplateId { get; set; }

    public bool? Enabled { get; set; }

    public bool? Readonly { get; set; }

    public double? Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Min.HasValue)
        dictionary["min"] = (object) this.Min;
      if (this.Max.HasValue)
        dictionary["max"] = (object) this.Max;
      string selection = this.Selection;
      if ((selection != null ? (selection.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selection"] = (object) this.Selection;
      string precision = this.Precision;
      if ((precision != null ? (precision.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["precision"] = (object) this.Precision;
      if (this.Tooltip.HasValue)
        dictionary["tooltip"] = (object) this.Tooltip;
      Dictionary<string, object> source = this.Label.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["label"] = (object) source;
      else if (this.Label.Enabled.HasValue)
        dictionary["label"] = (object) this.Label.Enabled;
      if (this.SelectValueOnFocus.HasValue)
        dictionary["selectValueOnFocus"] = (object) this.SelectValueOnFocus;
      if (this.ItemTemplateId.HasValue())
        dictionary["itemTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ItemTemplateId)
        };
      else if (this.ItemTemplate.HasValue())
        dictionary["itemTemplate"] = (object) this.ItemTemplate;
      if (this.SelectedTemplateId.HasValue())
        dictionary["selectedTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.SelectedTemplateId)
        };
      else if (this.SelectedTemplate.HasValue())
        dictionary["selectedTemplate"] = (object) this.SelectedTemplate;
      if (this.HoveredTemplateId.HasValue())
        dictionary["hoveredTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.HoveredTemplateId)
        };
      else if (this.HoveredTemplate.HasValue())
        dictionary["hoveredTemplate"] = (object) this.HoveredTemplate;
      if (this.Enabled.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      if (this.Readonly.HasValue)
        dictionary["readonly"] = (object) this.Readonly;
      if (this.Value.HasValue)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
