// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridSelectableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridSelectableSettings
  {
    public GridSelectableSettings()
    {
      this.Mode = GridSelectionMode.Single;
      this.Type = GridSelectionType.Row;
    }

    public bool Enabled { get; set; }

    public GridSelectionMode Mode { get; set; }

    public GridSelectionType Type { get; set; }

    public bool IgnoreOverlapped { get; set; }

    public IDictionary<string, object> Serialize() => (IDictionary<string, object>) new Dictionary<string, object>()
    {
      ["mode"] = (object) string.Format("{0}, {1}", (object) this.Mode, (object) this.Type),
      ["ignoreOverlapped"] = (object) this.IgnoreOverlapped
    };
  }
}
