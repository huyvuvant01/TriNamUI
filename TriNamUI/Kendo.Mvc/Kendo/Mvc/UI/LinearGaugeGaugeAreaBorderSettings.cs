﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.LinearGaugeGaugeAreaBorderSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class LinearGaugeGaugeAreaBorderSettings
  {
    public double? Opacity { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      return dictionary;
    }

    public string Color { get; set; }

    public ChartDashType? DashType { get; set; }

    public double? Width { get; set; }

    public LinearGauge LinearGauge { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      ChartDashType? dashType = this.DashType;
      if (dashType.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        dashType = this.DashType;
        ref ChartDashType? local = ref dashType;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["dashType"] = (object) str;
      }
      if (this.Width.HasValue)
        dictionary1["width"] = (object) this.Width;
      return dictionary1;
    }
  }
}