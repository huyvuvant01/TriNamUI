// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartCategoryAxisRangeLabelsRotationSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ChartCategoryAxisRangeLabelsRotationSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Align { get; set; }

    public double? Angle { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string align = this.Align;
      if ((align != null ? (align.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["align"] = (object) this.Align;
      if (this.Angle.HasValue)
        dictionary["angle"] = (object) this.Angle;
      return dictionary;
    }
  }
}
