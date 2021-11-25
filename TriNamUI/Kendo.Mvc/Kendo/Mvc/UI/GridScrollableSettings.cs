// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridScrollableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridScrollableSettings : JsonObject
  {
    public GridScrollableSettings()
    {
      this.Height = "400px";
      this.Virtual = new GridVirtualizationSettings();
    }

    public bool Enabled { get; set; }

    public string Height { get; set; }

    public GridVirtualizationSettings Virtual { get; set; }

    public bool Endless { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Virtual.Enabled)
      {
        json["virtual"] = (object) this.Virtual.Enabled;
      }
      else
      {
        GridVirtualizationMode? mode = this.Virtual.Mode;
        if (mode.HasValue)
        {
          IDictionary<string, object> dictionary = json;
          mode = this.Virtual.Mode;
          string str = mode.Value.Serialize();
          dictionary["virtual"] = (object) str;
        }
      }
      if (this.Endless)
        json["endless"] = (object) this.Endless;
      if (this.Height == null)
        return;
      json["height"] = (object) this.Height;
    }
  }
}
