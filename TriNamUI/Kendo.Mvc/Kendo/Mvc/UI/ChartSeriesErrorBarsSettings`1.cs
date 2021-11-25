// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesErrorBarsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesErrorBarsSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Value { get; set; }

    public ClientHandlerDescriptor ValueHandler { get; set; }

    public ClientHandlerDescriptor Visual { get; set; }

    public string XValue { get; set; }

    public ClientHandlerDescriptor XValueHandler { get; set; }

    public string YValue { get; set; }

    public ClientHandlerDescriptor YValueHandler { get; set; }

    public bool? EndCaps { get; set; }

    public string Color { get; set; }

    public ChartSeriesErrorBarsLineSettings<T> Line { get; } = new ChartSeriesErrorBarsLineSettings<T>();

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      ClientHandlerDescriptor valueHandler = this.ValueHandler;
      if ((valueHandler != null ? (valueHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["value"] = (object) this.ValueHandler;
      }
      else
      {
        string str = this.Value;
        if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["value"] = (object) this.Value;
      }
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.Visual;
      ClientHandlerDescriptor xvalueHandler = this.XValueHandler;
      if ((xvalueHandler != null ? (xvalueHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["xValue"] = (object) this.XValueHandler;
      }
      else
      {
        string xvalue = this.XValue;
        if ((xvalue != null ? (xvalue.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["xValue"] = (object) this.XValue;
      }
      ClientHandlerDescriptor yvalueHandler = this.YValueHandler;
      if ((yvalueHandler != null ? (yvalueHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["yValue"] = (object) this.YValueHandler;
      }
      else
      {
        string yvalue = this.YValue;
        if ((yvalue != null ? (yvalue.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["yValue"] = (object) this.YValue;
      }
      if (this.EndCaps.HasValue)
        dictionary["endCaps"] = (object) this.EndCaps;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      Dictionary<string, object> source = this.Line.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["line"] = (object) source;
      return dictionary;
    }
  }
}
