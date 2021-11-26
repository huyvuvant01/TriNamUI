// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.LinearGaugeScaleSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class LinearGaugeScaleSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public LinearGaugeScaleLineSettings Line { get; } = new LinearGaugeScaleLineSettings();

    public LinearGaugeScaleLabelsSettings Labels { get; } = new LinearGaugeScaleLabelsSettings();

    public LinearGaugeScaleMajorTicksSettings MajorTicks { get; } = new LinearGaugeScaleMajorTicksSettings();

    public double? MajorUnit { get; set; }

    public double? Max { get; set; }

    public double? Min { get; set; }

    public LinearGaugeScaleMinorTicksSettings MinorTicks { get; } = new LinearGaugeScaleMinorTicksSettings();

    public double? MinorUnit { get; set; }

    public bool? Mirror { get; set; }

    public List<LinearGaugeScaleSettingsRange> Ranges { get; set; } = new List<LinearGaugeScaleSettingsRange>();

    public string RangePlaceholderColor { get; set; }

    public double? RangeSize { get; set; }

    public bool? Reverse { get; set; }

    public bool? Vertical { get; set; }

    public LinearGauge LinearGauge { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Line.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["line"] = (object) source1;
      Dictionary<string, object> source2 = this.Labels.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["labels"] = (object) source2;
      Dictionary<string, object> source3 = this.MajorTicks.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["majorTicks"] = (object) source3;
      if (this.MajorUnit.HasValue)
        dictionary["majorUnit"] = (object) this.MajorUnit;
      if (this.Max.HasValue)
        dictionary["max"] = (object) this.Max;
      if (this.Min.HasValue)
        dictionary["min"] = (object) this.Min;
      Dictionary<string, object> source4 = this.MinorTicks.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["minorTicks"] = (object) source4;
      if (this.MinorUnit.HasValue)
        dictionary["minorUnit"] = (object) this.MinorUnit;
      if (this.Mirror.HasValue)
        dictionary["mirror"] = (object) this.Mirror;
      IEnumerable<Dictionary<string, object>> source5 = this.Ranges.Select<LinearGaugeScaleSettingsRange, Dictionary<string, object>>((Func<LinearGaugeScaleSettingsRange, Dictionary<string, object>>) (i => i.Serialize()));
      if (source5.Any<Dictionary<string, object>>())
        dictionary["ranges"] = (object) source5;
      string placeholderColor = this.RangePlaceholderColor;
      if ((placeholderColor != null ? (placeholderColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rangePlaceholderColor"] = (object) this.RangePlaceholderColor;
      if (this.RangeSize.HasValue)
        dictionary["rangeSize"] = (object) this.RangeSize;
      if (this.Reverse.HasValue)
        dictionary["reverse"] = (object) this.Reverse;
      if (this.Vertical.HasValue)
        dictionary["vertical"] = (object) this.Vertical;
      return dictionary;
    }
  }
}
