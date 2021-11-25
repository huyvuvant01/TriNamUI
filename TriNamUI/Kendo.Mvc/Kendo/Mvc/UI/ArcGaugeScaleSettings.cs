﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ArcGaugeScaleSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ArcGaugeScaleSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? EndAngle { get; set; }

    public ArcGaugeScaleLabelsSettings Labels { get; } = new ArcGaugeScaleLabelsSettings();

    public ArcGaugeScaleMajorTicksSettings MajorTicks { get; } = new ArcGaugeScaleMajorTicksSettings();

    public double? MajorUnit { get; set; }

    public double? Max { get; set; }

    public double? Min { get; set; }

    public ArcGaugeScaleMinorTicksSettings MinorTicks { get; } = new ArcGaugeScaleMinorTicksSettings();

    public double? MinorUnit { get; set; }

    public string RangeLineCap { get; set; }

    public string RangePlaceholderColor { get; set; }

    public double? RangeSize { get; set; }

    public double? RangeDistance { get; set; }

    public bool? Reverse { get; set; }

    public double? StartAngle { get; set; }

    public ArcGauge ArcGauge { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.EndAngle.HasValue)
        dictionary["endAngle"] = (object) this.EndAngle;
      Dictionary<string, object> source1 = this.Labels.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["labels"] = (object) source1;
      Dictionary<string, object> source2 = this.MajorTicks.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["majorTicks"] = (object) source2;
      if (this.MajorUnit.HasValue)
        dictionary["majorUnit"] = (object) this.MajorUnit;
      if (this.Max.HasValue)
        dictionary["max"] = (object) this.Max;
      if (this.Min.HasValue)
        dictionary["min"] = (object) this.Min;
      Dictionary<string, object> source3 = this.MinorTicks.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["minorTicks"] = (object) source3;
      if (this.MinorUnit.HasValue)
        dictionary["minorUnit"] = (object) this.MinorUnit;
      string rangeLineCap = this.RangeLineCap;
      if ((rangeLineCap != null ? (rangeLineCap.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rangeLineCap"] = (object) this.RangeLineCap;
      string placeholderColor = this.RangePlaceholderColor;
      if ((placeholderColor != null ? (placeholderColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rangePlaceholderColor"] = (object) this.RangePlaceholderColor;
      if (this.RangeSize.HasValue)
        dictionary["rangeSize"] = (object) this.RangeSize;
      if (this.RangeDistance.HasValue)
        dictionary["rangeDistance"] = (object) this.RangeDistance;
      if (this.Reverse.HasValue)
        dictionary["reverse"] = (object) this.Reverse;
      if (this.StartAngle.HasValue)
        dictionary["startAngle"] = (object) this.StartAngle;
      return dictionary;
    }
  }
}
