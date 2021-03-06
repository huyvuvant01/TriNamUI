// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesTargetSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesTargetSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public ChartSeriesTargetBorderSettings<T> Border { get; } = new ChartSeriesTargetBorderSettings<T>();

    public string Color { get; set; }

    public ClientHandlerDescriptor ColorHandler { get; set; }

    public ChartSeriesTargetLineSettings<T> Line { get; } = new ChartSeriesTargetLineSettings<T>();

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["border"] = (object) source1;
      ClientHandlerDescriptor colorHandler = this.ColorHandler;
      if ((colorHandler != null ? (colorHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["color"] = (object) this.ColorHandler;
      }
      else
      {
        string color = this.Color;
        if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["color"] = (object) this.Color;
      }
      Dictionary<string, object> source2 = this.Line.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["line"] = (object) source2;
      return dictionary;
    }
  }
}
