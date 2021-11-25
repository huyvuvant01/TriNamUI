// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ContextMenuScrollableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ContextMenuScrollableSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? Distance { get; set; }

    public bool? Enabled { get; set; }

    public ContextMenu ContextMenu { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Distance.HasValue)
        dictionary["distance"] = (object) this.Distance;
      return dictionary;
    }
  }
}
