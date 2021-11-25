// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CheckBoxGroup
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
  public class CheckBoxGroup : WidgetBase, IFormEditor
  {
    public CheckBoxGroup(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public IEnumerable<string> Value { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      new CheckBoxGroupHtmlBuilder(this, this.Generator).BuildGroup().WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (CheckBoxGroup), this.Serialize()));

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Value != null && this.Value.Count<string>() > 0)
        dictionary["value"] = (object) this.Value;
      return (IDictionary<string, object>) dictionary;
    }

    public bool? Enabled { get; set; }

    public string InputName { get; set; }

    public List<CheckBoxGroupItem> Items { get; set; } = new List<CheckBoxGroupItem>();

    public CheckBoxGroupLayout? Layout { get; set; }

    public CheckBoxGroupLabelPosition? LabelPosition { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Enabled.HasValue)
        dictionary1["enabled"] = (object) this.Enabled;
      string inputName = this.InputName;
      if ((inputName != null ? (inputName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["inputName"] = (object) this.InputName;
      IEnumerable<Dictionary<string, object>> source = this.Items.Select<CheckBoxGroupItem, Dictionary<string, object>>((Func<CheckBoxGroupItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary1["items"] = (object) source;
      if (this.Layout.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        CheckBoxGroupLayout? layout = this.Layout;
        ref CheckBoxGroupLayout? local = ref layout;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["layout"] = (object) str;
      }
      if (this.LabelPosition.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        CheckBoxGroupLabelPosition? labelPosition = this.LabelPosition;
        ref CheckBoxGroupLabelPosition? local = ref labelPosition;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["labelPosition"] = (object) str;
      }
      return dictionary1;
    }
  }
}
