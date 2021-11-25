// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridPageableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridPageableSettings : PageableSettings
  {
    public GridPageableSettings() => this.AlwaysVisible = true;

    public bool AlwaysVisible { get; set; }

    public GridPagerPosition? Position { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      if (!this.AlwaysVisible)
        json["alwaysVisible"] = (object) this.AlwaysVisible;
      if (!this.Position.HasValue)
        return;
      IDictionary<string, object> dictionary = json;
      GridPagerPosition? position = this.Position;
      ref GridPagerPosition? local = ref position;
      string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
      dictionary["position"] = (object) str;
    }
  }
}
