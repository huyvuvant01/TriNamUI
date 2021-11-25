// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesAggregateSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesAggregateSettings<T> where T : class
  {
    public ChartSeriesAggregate? Close { get; set; }

    public ClientHandlerDescriptor CloseHandler { get; set; }

    public ChartSeriesAggregate? High { get; set; }

    public ClientHandlerDescriptor HighHandler { get; set; }

    public ChartSeriesAggregate? Low { get; set; }

    public ClientHandlerDescriptor LowHandler { get; set; }

    public ChartSeriesAggregate? Open { get; set; }

    public ClientHandlerDescriptor OpenHandler { get; set; }

    public ChartSeriesAggregate? Lower { get; set; }

    public ClientHandlerDescriptor LowerHandler { get; set; }

    public ChartSeriesAggregate? Mean { get; set; }

    public ClientHandlerDescriptor MeanHandler { get; set; }

    public ChartSeriesAggregate? Median { get; set; }

    public ClientHandlerDescriptor MedianHandler { get; set; }

    public ChartSeriesAggregate? Outliers { get; set; }

    public ClientHandlerDescriptor OutliersHandler { get; set; }

    public ChartSeriesAggregate? Q1 { get; set; }

    public ClientHandlerDescriptor Q1Handler { get; set; }

    public ChartSeriesAggregate? Q3 { get; set; }

    public ClientHandlerDescriptor Q3Handler { get; set; }

    public ChartSeriesAggregate? Upper { get; set; }

    public ClientHandlerDescriptor UpperHandler { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      ClientHandlerDescriptor closeHandler = this.CloseHandler;
      ChartSeriesAggregate? nullable;
      if ((closeHandler != null ? (closeHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["close"] = (object) this.CloseHandler;
      }
      else
      {
        nullable = this.Close;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          nullable = this.Close;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["close"] = (object) str;
        }
      }
      ClientHandlerDescriptor highHandler = this.HighHandler;
      if ((highHandler != null ? (highHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["high"] = (object) this.HighHandler;
      }
      else
      {
        nullable = this.High;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary3 = dictionary1;
          nullable = this.High;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary3["high"] = (object) str;
        }
      }
      ClientHandlerDescriptor lowHandler = this.LowHandler;
      if ((lowHandler != null ? (lowHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["low"] = (object) this.LowHandler;
      }
      else
      {
        nullable = this.Low;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary4 = dictionary1;
          nullable = this.Low;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary4["low"] = (object) str;
        }
      }
      ClientHandlerDescriptor openHandler = this.OpenHandler;
      if ((openHandler != null ? (openHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["open"] = (object) this.OpenHandler;
      }
      else
      {
        nullable = this.Open;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary5 = dictionary1;
          nullable = this.Open;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary5["open"] = (object) str;
        }
      }
      ClientHandlerDescriptor lowerHandler = this.LowerHandler;
      if ((lowerHandler != null ? (lowerHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["lower"] = (object) this.LowerHandler;
      }
      else
      {
        nullable = this.Lower;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary6 = dictionary1;
          nullable = this.Lower;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary6["lower"] = (object) str;
        }
      }
      ClientHandlerDescriptor meanHandler = this.MeanHandler;
      if ((meanHandler != null ? (meanHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["mean"] = (object) this.MeanHandler;
      }
      else
      {
        nullable = this.Mean;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary7 = dictionary1;
          nullable = this.Mean;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary7["mean"] = (object) str;
        }
      }
      ClientHandlerDescriptor medianHandler = this.MedianHandler;
      if ((medianHandler != null ? (medianHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["median"] = (object) this.MedianHandler;
      }
      else
      {
        nullable = this.Median;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary8 = dictionary1;
          nullable = this.Median;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary8["median"] = (object) str;
        }
      }
      ClientHandlerDescriptor outliersHandler = this.OutliersHandler;
      if ((outliersHandler != null ? (outliersHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["outliers"] = (object) this.OutliersHandler;
      }
      else
      {
        nullable = this.Outliers;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary9 = dictionary1;
          nullable = this.Outliers;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary9["outliers"] = (object) str;
        }
      }
      ClientHandlerDescriptor q1Handler = this.Q1Handler;
      if ((q1Handler != null ? (q1Handler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["q1"] = (object) this.Q1Handler;
      }
      else
      {
        nullable = this.Q1;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary10 = dictionary1;
          nullable = this.Q1;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary10["q1"] = (object) str;
        }
      }
      ClientHandlerDescriptor q3Handler = this.Q3Handler;
      if ((q3Handler != null ? (q3Handler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["q3"] = (object) this.Q3Handler;
      }
      else
      {
        nullable = this.Q3;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary11 = dictionary1;
          nullable = this.Q3;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary11["q3"] = (object) str;
        }
      }
      ClientHandlerDescriptor upperHandler = this.UpperHandler;
      if ((upperHandler != null ? (upperHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["upper"] = (object) this.UpperHandler;
      }
      else
      {
        nullable = this.Upper;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary12 = dictionary1;
          nullable = this.Upper;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary12["upper"] = (object) str;
        }
      }
      return dictionary1;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();
  }
}
