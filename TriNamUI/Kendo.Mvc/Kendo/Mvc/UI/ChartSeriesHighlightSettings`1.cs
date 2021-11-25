﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesHighlightSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesHighlightSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public ChartSeriesHighlightBorderSettings<T> Border { get; } = new ChartSeriesHighlightBorderSettings<T>();

    public string Color { get; set; }

    public double? InactiveOpacity { get; set; }

    public ChartSeriesHighlightLineSettings<T> Line { get; } = new ChartSeriesHighlightLineSettings<T>();

    public double? Opacity { get; set; }

    public ClientHandlerDescriptor Toggle { get; set; }

    public bool? Visible { get; set; }

    public ClientHandlerDescriptor Visual { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["border"] = (object) source1;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      if (this.InactiveOpacity.HasValue)
        dictionary["inactiveOpacity"] = (object) this.InactiveOpacity;
      Dictionary<string, object> source2 = this.Line.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["line"] = (object) source2;
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      ClientHandlerDescriptor toggle = this.Toggle;
      if ((toggle != null ? (toggle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggle"] = (object) this.Toggle;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.Visual;
      return dictionary;
    }
  }
}
