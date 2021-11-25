// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartAxisDefaultsMinorGridLinesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ChartAxisDefaultsMinorGridLinesSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Color { get; set; }

    public ChartDashType? DashType { get; set; }

    public bool? Visible { get; set; }

    public double? Width { get; set; }

    public double? Step { get; set; }

    public double? Skip { get; set; }

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
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      double? nullable = this.Width;
      if (nullable.HasValue)
        dictionary1["width"] = (object) this.Width;
      nullable = this.Step;
      if (nullable.HasValue)
        dictionary1["step"] = (object) this.Step;
      nullable = this.Skip;
      if (nullable.HasValue)
        dictionary1["skip"] = (object) this.Skip;
      return dictionary1;
    }
  }
}
