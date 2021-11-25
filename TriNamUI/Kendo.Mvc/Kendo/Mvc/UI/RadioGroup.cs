// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.RadioGroup
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
  public class RadioGroup : WidgetBase, IFormEditor
  {
    public RadioGroup(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      new RadioGroupHtmlBuilder(this, this.Generator).BuildGroup().WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize() => (IDictionary<string, object>) this.SerializeSettings();

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (RadioGroup), this.Serialize()));

    public bool? Enabled { get; set; }

    public string InputName { get; set; }

    public List<RadioGroupItem> Items { get; set; } = new List<RadioGroupItem>();

    public string Value { get; set; }

    public RadioGroupLayout? Layout { get; set; }

    public RadioGroupLabelPosition? LabelPosition { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Enabled.HasValue)
        dictionary1["enabled"] = (object) this.Enabled;
      string inputName = this.InputName;
      if ((inputName != null ? (inputName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["inputName"] = (object) this.InputName;
      IEnumerable<Dictionary<string, object>> source = this.Items.Select<RadioGroupItem, Dictionary<string, object>>((Func<RadioGroupItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary1["items"] = (object) source;
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      if (this.Layout.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        RadioGroupLayout? layout = this.Layout;
        ref RadioGroupLayout? local = ref layout;
        string str2 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["layout"] = (object) str2;
      }
      if (this.LabelPosition.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        RadioGroupLabelPosition? labelPosition = this.LabelPosition;
        ref RadioGroupLabelPosition? local = ref labelPosition;
        string str3 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["labelPosition"] = (object) str3;
      }
      return dictionary1;
    }
  }
}
