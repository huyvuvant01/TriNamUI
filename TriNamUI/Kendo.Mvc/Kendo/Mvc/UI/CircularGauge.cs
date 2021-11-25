// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CircularGauge
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class CircularGauge : WidgetBase
  {
    public CircularGauge(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (CircularGauge), (IDictionary<string, object>) dictionary));
    }

    public string CenterTemplate { get; set; }

    public string CenterTemplateId { get; set; }

    public string Color { get; set; }

    public List<CircularGaugeColor> Colors { get; set; } = new List<CircularGaugeColor>();

    public CircularGaugeGaugeAreaSettings GaugeArea { get; } = new CircularGaugeGaugeAreaSettings();

    public double? Opacity { get; set; }

    public string RenderAs { get; set; }

    public CircularGaugeScaleSettings Scale { get; } = new CircularGaugeScaleSettings();

    public string Theme { get; set; }

    public bool? Transitions { get; set; }

    public double? Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.CenterTemplateId.HasValue())
        dictionary["centerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.CenterTemplateId)
        };
      else if (this.CenterTemplate.HasValue())
        dictionary["centerTemplate"] = (object) this.CenterTemplate;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      IEnumerable<Dictionary<string, object>> source1 = this.Colors.Select<CircularGaugeColor, Dictionary<string, object>>((Func<CircularGaugeColor, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["colors"] = (object) source1;
      Dictionary<string, object> source2 = this.GaugeArea.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["gaugeArea"] = (object) source2;
      double? opacity = this.Opacity;
      if (opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      string renderAs = this.RenderAs;
      if ((renderAs != null ? (renderAs.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["renderAs"] = (object) this.RenderAs;
      Dictionary<string, object> source3 = this.Scale.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["scale"] = (object) source3;
      string theme = this.Theme;
      if ((theme != null ? (theme.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["theme"] = (object) this.Theme;
      if (this.Transitions.HasValue)
        dictionary["transitions"] = (object) this.Transitions;
      opacity = this.Value;
      if (opacity.HasValue)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
