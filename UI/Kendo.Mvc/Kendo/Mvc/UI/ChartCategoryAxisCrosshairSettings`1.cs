// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartCategoryAxisCrosshairSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartCategoryAxisCrosshairSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Color { get; set; }

    public ChartDashType? DashType { get; set; }

    public double? Opacity { get; set; }

    public ChartCategoryAxisCrosshairTooltipSettings<T> Tooltip { get; } = new ChartCategoryAxisCrosshairTooltipSettings<T>();

    public bool? Visible { get; set; }

    public double? Width { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

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
      double? nullable = this.Opacity;
      if (nullable.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      Dictionary<string, object> source = this.Tooltip.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["tooltip"] = (object) source;
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      nullable = this.Width;
      if (nullable.HasValue)
        dictionary1["width"] = (object) this.Width;
      return dictionary1;
    }
  }
}
