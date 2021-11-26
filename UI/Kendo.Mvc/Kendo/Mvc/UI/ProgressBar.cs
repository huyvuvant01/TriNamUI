// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ProgressBar
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
  public class ProgressBar : WidgetBase
  {
    public ProgressBar(ViewContext viewContext)
      : base(viewContext)
    {
      this.Enable = new bool?(true);
      this.Reverse = new bool?(false);
      this.ShowStatus = new bool?(true);
      this.Animation = new ProgressBarAnimationSettings();
    }

    public object Value { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (!this.Animation.Enable)
        dictionary["animation"] = (object) false;
      if (this.Value != null)
        dictionary["value"] = this.Value;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ProgressBar), (IDictionary<string, object>) dictionary));
    }

    public ProgressBarAnimationSettings Animation { get; } = new ProgressBarAnimationSettings();

    public bool? AriaRole { get; set; }

    public double? ChunkCount { get; set; }

    public bool? Enable { get; set; }

    public string Label { get; set; }

    public string LabelId { get; set; }

    public double? Max { get; set; }

    public double? Min { get; set; }

    public bool? Reverse { get; set; }

    public bool? ShowStatus { get; set; }

    public ProgressBarOrientation? Orientation { get; set; }

    public ProgressBarType? Type { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      Dictionary<string, object> source = this.Animation.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["animation"] = (object) source;
      else if (this.Animation.Enabled.HasValue)
        dictionary1["animation"] = (object) this.Animation.Enabled;
      bool? nullable1 = this.AriaRole;
      if (nullable1.HasValue)
        dictionary1["ariaRole"] = (object) this.AriaRole;
      double? nullable2 = this.ChunkCount;
      if (nullable2.HasValue)
        dictionary1["chunkCount"] = (object) this.ChunkCount;
      nullable1 = this.Enable;
      if (nullable1.HasValue)
        dictionary1["enable"] = (object) this.Enable;
      string label = this.Label;
      if ((label != null ? (label.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["label"] = (object) this.Label;
      string labelId = this.LabelId;
      if ((labelId != null ? (labelId.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["labelId"] = (object) this.LabelId;
      nullable2 = this.Max;
      if (nullable2.HasValue)
        dictionary1["max"] = (object) this.Max;
      nullable2 = this.Min;
      if (nullable2.HasValue)
        dictionary1["min"] = (object) this.Min;
      nullable1 = this.Reverse;
      if (nullable1.HasValue)
        dictionary1["reverse"] = (object) this.Reverse;
      nullable1 = this.ShowStatus;
      if (nullable1.HasValue)
        dictionary1["showStatus"] = (object) this.ShowStatus;
      ProgressBarOrientation? orientation = this.Orientation;
      if (orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        orientation = this.Orientation;
        ref ProgressBarOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      ProgressBarType? type = this.Type;
      if (type.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        type = this.Type;
        ref ProgressBarType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
