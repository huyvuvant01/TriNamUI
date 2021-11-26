// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartCategoryAxisSelectSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartCategoryAxisSelectSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public object From { get; set; }

    public object Max { get; set; }

    public object Min { get; set; }

    public ChartCategoryAxisSelectMousewheelSettings<T> Mousewheel { get; } = new ChartCategoryAxisSelectMousewheelSettings<T>();

    public object To { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.From != null)
        dictionary["from"] = this.From;
      if (this.Max != null)
        dictionary["max"] = this.Max;
      if (this.Min != null)
        dictionary["min"] = this.Min;
      Dictionary<string, object> source = this.Mousewheel.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["mousewheel"] = (object) source;
      if (this.To != null)
        dictionary["to"] = this.To;
      return dictionary;
    }
  }
}
