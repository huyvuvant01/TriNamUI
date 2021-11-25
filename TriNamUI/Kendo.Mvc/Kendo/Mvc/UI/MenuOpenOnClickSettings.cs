// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MenuOpenOnClickSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class MenuOpenOnClickSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? RootMenuItems { get; set; }

    public bool? SubMenuItems { get; set; }

    public bool? Enabled { get; set; }

    public Menu Menu { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.RootMenuItems.HasValue)
        dictionary["rootMenuItems"] = (object) this.RootMenuItems;
      if (this.SubMenuItems.HasValue)
        dictionary["subMenuItems"] = (object) this.SubMenuItems;
      return dictionary;
    }
  }
}
