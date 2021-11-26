// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ArcGaugeGaugeAreaSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ArcGaugeGaugeAreaSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ArcGaugeGaugeAreaBorderSettings Border { get; } = new ArcGaugeGaugeAreaBorderSettings();

    public double? Height { get; set; }

    public ArcGaugeGaugeAreaMarginSettings Margin { get; } = new ArcGaugeGaugeAreaMarginSettings();

    public double? Width { get; set; }

    public ArcGauge ArcGauge { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["border"] = (object) source1;
      double? nullable = this.Height;
      if (nullable.HasValue)
        dictionary["height"] = (object) this.Height;
      Dictionary<string, object> source2 = this.Margin.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["margin"] = (object) source2;
      nullable = this.Width;
      if (nullable.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
