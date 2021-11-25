// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnExportableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridColumnExportableSettings
  {
    public GridColumnExportableSettings()
    {
      this.Enabled = true;
      this.Excel = true;
      this.Pdf = true;
    }

    public bool Enabled { get; set; }

    public bool Excel { get; set; }

    public bool Pdf { get; set; }

    public IDictionary<string, object> Serialize() => (IDictionary<string, object>) new Dictionary<string, object>()
    {
      ["excel"] = (object) this.Excel,
      ["pdf"] = (object) this.Pdf
    };
  }
}
