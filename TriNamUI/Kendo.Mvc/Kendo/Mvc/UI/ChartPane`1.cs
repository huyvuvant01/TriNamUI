// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartPane`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartPane<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ChartPaneBorderSettings<T> Border { get; } = new ChartPaneBorderSettings<T>();

    public bool? Clip { get; set; }

    public double? Height { get; set; }

    public ChartPaneMarginSettings<T> Margin { get; } = new ChartPaneMarginSettings<T>();

    public string Name { get; set; }

    public ChartPanePaddingSettings<T> Padding { get; } = new ChartPanePaddingSettings<T>();

    public ChartPaneTitleSettings<T> Title { get; } = new ChartPaneTitleSettings<T>();

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["border"] = (object) source1;
      if (this.Clip.HasValue)
        dictionary["clip"] = (object) this.Clip;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      Dictionary<string, object> source2 = this.Margin.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["margin"] = (object) source2;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      Dictionary<string, object> source3 = this.Padding.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["padding"] = (object) source3;
      Dictionary<string, object> source4 = this.Title.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["title"] = (object) source4;
      return dictionary;
    }
  }
}
