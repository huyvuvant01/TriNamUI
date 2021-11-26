// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartZoomableSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartZoomableSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public ChartZoomableMousewheelSettings<T> Mousewheel { get; } = new ChartZoomableMousewheelSettings<T>();

    public ChartZoomableSelectionSettings<T> Selection { get; } = new ChartZoomableSelectionSettings<T>();

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Mousewheel.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["mousewheel"] = (object) source1;
      else if (this.Mousewheel.Enabled.HasValue)
        dictionary["mousewheel"] = (object) this.Mousewheel.Enabled;
      Dictionary<string, object> source2 = this.Selection.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["selection"] = (object) source2;
      else if (this.Selection.Enabled.HasValue)
        dictionary["selection"] = (object) this.Selection.Enabled;
      return dictionary;
    }
  }
}
