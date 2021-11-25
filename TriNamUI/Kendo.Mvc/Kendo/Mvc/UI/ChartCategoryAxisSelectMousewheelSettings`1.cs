// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartCategoryAxisSelectMousewheelSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ChartCategoryAxisSelectMousewheelSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Reverse { get; set; }

    public ChartZoomDirection? Zoom { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Reverse.HasValue)
        dictionary1["reverse"] = (object) this.Reverse;
      if (this.Zoom.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ChartZoomDirection? zoom = this.Zoom;
        ref ChartZoomDirection? local = ref zoom;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["zoom"] = (object) str;
      }
      return dictionary1;
    }
  }
}
