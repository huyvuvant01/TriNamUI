// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.WindowDraggableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class WindowDraggableSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Containment { get; set; }

    public string Axis { get; set; }

    public string DragHandle { get; set; }

    public bool? Enabled { get; set; }

    public Window Window { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string containment = this.Containment;
      if ((containment != null ? (containment.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["containment"] = (object) this.Containment;
      string axis = this.Axis;
      if ((axis != null ? (axis.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["axis"] = (object) this.Axis;
      string dragHandle = this.DragHandle;
      if ((dragHandle != null ? (dragHandle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragHandle"] = (object) this.DragHandle;
      return dictionary;
    }
  }
}
