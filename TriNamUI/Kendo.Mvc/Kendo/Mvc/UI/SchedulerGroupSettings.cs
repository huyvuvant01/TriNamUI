// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerGroupSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerGroupSettings : JsonObject
  {
    public SchedulerGroupSettings() => this.Resources = new string[0];

    public string[] Resources { get; set; }

    public bool Date { get; set; }

    public SchedulerGroupOrientation Orientation { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Resources.Length != 0)
        json["resources"] = (object) this.Resources;
      if (this.Date)
        json["date"] = (object) this.Date;
      if (this.Orientation == SchedulerGroupOrientation.Default)
        return;
      json["orientation"] = (object) this.Orientation;
    }
  }
}
