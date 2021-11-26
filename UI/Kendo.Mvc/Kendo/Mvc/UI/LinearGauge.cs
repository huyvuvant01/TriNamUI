// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.LinearGauge
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
  public class LinearGauge : WidgetBase
  {
    public LinearGauge(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public List<LinearGaugePointer> Pointers { get; set; } = new List<LinearGaugePointer>();

    public LinearGaugePointer Pointer { get; set; } = new LinearGaugePointer();

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IEnumerable<Dictionary<string, object>> source = this.Pointers.Select<LinearGaugePointer, Dictionary<string, object>>((Func<LinearGaugePointer, Dictionary<string, object>>) (i => i.Serialize()));
      dictionary["pointer"] = !source.Any<Dictionary<string, object>>() ? (object) this.Pointer.Serialize() : (object) source;
      if (this.Theme.HasValue())
        dictionary.Add("theme", (object) this.Theme);
      bool? transitions = this.Transitions;
      if (transitions.HasValue)
      {
        transitions = this.Transitions;
        if (!transitions.Value)
          dictionary["transitions"] = (object) this.Transitions;
      }
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (LinearGauge), (IDictionary<string, object>) dictionary));
    }

    public LinearGaugeGaugeAreaSettings GaugeArea { get; } = new LinearGaugeGaugeAreaSettings();

    public RenderingMode? RenderAs { get; set; }

    public LinearGaugeScaleSettings Scale { get; } = new LinearGaugeScaleSettings();

    public string Theme { get; set; }

    public bool? Transitions { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      Dictionary<string, object> source1 = this.GaugeArea.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["gaugeArea"] = (object) source1;
      RenderingMode? renderAs = this.RenderAs;
      if (renderAs.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        renderAs = this.RenderAs;
        ref RenderingMode? local = ref renderAs;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["renderAs"] = (object) str;
      }
      Dictionary<string, object> source2 = this.Scale.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["scale"] = (object) source2;
      string theme = this.Theme;
      if ((theme != null ? (theme.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["theme"] = (object) this.Theme;
      if (this.Transitions.HasValue)
        dictionary1["transitions"] = (object) this.Transitions;
      return dictionary1;
    }
  }
}
