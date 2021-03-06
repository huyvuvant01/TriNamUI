// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.LinearGaugeScaleMinorTicksSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class LinearGaugeScaleMinorTicksSettings
  {
    public ChartDashType? DashType { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      if (this.DashType.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ChartDashType? dashType = this.DashType;
        ref ChartDashType? local = ref dashType;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["dashType"] = (object) str;
      }
      return dictionary1;
    }

    public string Color { get; set; }

    public double? Size { get; set; }

    public bool? Visible { get; set; }

    public double? Width { get; set; }

    public LinearGauge LinearGauge { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      double? nullable = this.Size;
      if (nullable.HasValue)
        dictionary["size"] = (object) this.Size;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      nullable = this.Width;
      if (nullable.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
