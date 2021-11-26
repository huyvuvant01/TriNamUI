// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Stepper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Stepper : WidgetBase
  {
    public Stepper(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("nav", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Stepper), (IDictionary<string, object>) dictionary));
    }

    public bool? Indicator { get; set; }

    public bool? Label { get; set; }

    public bool? Linear { get; set; }

    public bool? SelectOnFocus { get; set; }

    public List<StepperStep> Steps { get; set; } = new List<StepperStep>();

    public StepperOrientationType? Orientation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Indicator.HasValue)
        dictionary1["indicator"] = (object) this.Indicator;
      if (this.Label.HasValue)
        dictionary1["label"] = (object) this.Label;
      if (this.Linear.HasValue)
        dictionary1["linear"] = (object) this.Linear;
      if (this.SelectOnFocus.HasValue)
        dictionary1["selectOnFocus"] = (object) this.SelectOnFocus;
      IEnumerable<Dictionary<string, object>> source = this.Steps.Select<StepperStep, Dictionary<string, object>>((Func<StepperStep, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary1["steps"] = (object) source;
      if (this.Orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        StepperOrientationType? orientation = this.Orientation;
        ref StepperOrientationType? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      return dictionary1;
    }
  }
}
