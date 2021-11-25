// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.LinearGaugePointerTrackSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class LinearGaugePointerTrackSettings
  {
    public LinearGaugePointerTrackBorderSettings Border { get; } = new LinearGaugePointerTrackBorderSettings();

    public string Color { get; set; }

    public double? Opacity { get; set; }

    public double? Size { get; set; }

    public bool? Visible { get; set; }

    public LinearGauge LinearGauge { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source = this.Border.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["border"] = (object) source;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      if (this.Size.HasValue)
        dictionary["size"] = (object) this.Size;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
