// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.RadialGauge
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
  public class RadialGauge : WidgetBase
  {
    public RadialGauge(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public List<RadialGaugePointer> Pointers { get; set; } = new List<RadialGaugePointer>();

    public RadialGaugePointer Pointer { get; set; } = new RadialGaugePointer();

    public RenderingMode? RenderAs { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      if (this.Theme.HasValue())
        dictionary1.Add("theme", (object) this.Theme);
      IEnumerable<Dictionary<string, object>> source = this.Pointers.Select<RadialGaugePointer, Dictionary<string, object>>((Func<RadialGaugePointer, Dictionary<string, object>>) (i => i.Serialize()));
      dictionary1["pointer"] = !source.Any<Dictionary<string, object>>() ? (object) this.Pointer.Serialize() : (object) source;
      RenderingMode? renderAs = this.RenderAs;
      if (renderAs.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        renderAs = this.RenderAs;
        string lowerInvariant = renderAs.ToString().ToLowerInvariant();
        dictionary2.Add("renderAs", (object) lowerInvariant);
      }
      if (this.Theme.HasValue())
        dictionary1["theme"] = (object) this.Theme;
      bool? transitions = this.Transitions;
      if (transitions.HasValue)
      {
        transitions = this.Transitions;
        if (!transitions.Value)
          dictionary1["transitions"] = (object) this.Transitions;
      }
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (RadialGauge), (IDictionary<string, object>) dictionary1));
    }

    public RadialGaugeGaugeAreaSettings GaugeArea { get; } = new RadialGaugeGaugeAreaSettings();

    public RadialGaugeScaleSettings Scale { get; } = new RadialGaugeScaleSettings();

    public string Theme { get; set; }

    public bool? Transitions { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      Dictionary<string, object> source1 = this.GaugeArea.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["gaugeArea"] = (object) source1;
      Dictionary<string, object> source2 = this.Scale.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["scale"] = (object) source2;
      string theme = this.Theme;
      if ((theme != null ? (theme.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["theme"] = (object) this.Theme;
      if (this.Transitions.HasValue)
        dictionary["transitions"] = (object) this.Transitions;
      return dictionary;
    }
  }
}
