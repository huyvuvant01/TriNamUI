﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartPannableSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ChartPannableSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public ChartActivationKey? Key { get; set; }

    public ChartAxisLock? Lock { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Key.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ChartActivationKey? key = this.Key;
        ref ChartActivationKey? local = ref key;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["key"] = (object) str;
      }
      if (this.Lock.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        ChartAxisLock? nullable = this.Lock;
        ref ChartAxisLock? local = ref nullable;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["lock"] = (object) str;
      }
      return dictionary1;
    }
  }
}
