﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapControlsNavigatorSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class MapControlsNavigatorSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public MapControlPosition? Position { get; set; }

    public bool? Enabled { get; set; }

    public Map Map { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        MapControlPosition? position = this.Position;
        ref MapControlPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
