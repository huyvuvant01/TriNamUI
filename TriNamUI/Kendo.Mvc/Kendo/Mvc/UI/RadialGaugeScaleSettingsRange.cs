// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.RadialGaugeScaleSettingsRange
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class RadialGaugeScaleSettingsRange
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? From { get; set; }

    public double? To { get; set; }

    public double? Opacity { get; set; }

    public string Color { get; set; }

    public RadialGauge RadialGauge { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.From.HasValue)
        dictionary["from"] = (object) this.From;
      if (this.To.HasValue)
        dictionary["to"] = (object) this.To;
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      return dictionary;
    }
  }
}
