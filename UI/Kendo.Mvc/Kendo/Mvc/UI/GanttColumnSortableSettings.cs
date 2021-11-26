// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttColumnSortableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GanttColumnSortableSettings
  {
    public GanttColumnSortableSettings()
    {
      this.Enabled = new bool?(true);
      this.Compare = new ClientHandlerDescriptor();
    }

    public bool? Enabled { get; set; }

    public ClientHandlerDescriptor Compare { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Compare != null && this.Compare.HasValue())
        dictionary["compare"] = (object) this.Compare;
      return dictionary;
    }
  }
}
