// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.RadialGaugeGaugeAreaSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class RadialGaugeGaugeAreaSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public RadialGaugeGaugeAreaBorderSettings Border { get; } = new RadialGaugeGaugeAreaBorderSettings();

    public double? Height { get; set; }

    public RadialGaugeGaugeAreaMarginSettings Margin { get; } = new RadialGaugeGaugeAreaMarginSettings();

    public double? Width { get; set; }

    public string Background { get; set; }

    public RadialGauge RadialGauge { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["border"] = (object) source1;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      Dictionary<string, object> source2 = this.Margin.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["margin"] = (object) source2;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      return dictionary;
    }
  }
}
