// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListSelectableSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class TreeListSelectableSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      bool? enabled = this.Enabled;
      bool flag = true;
      if (enabled.GetValueOrDefault() == flag & enabled.HasValue)
      {
        TreeListSelectionMode? mode;
        TreeListSelectionType? type;
        if (this.Mode.HasValue || this.Type.HasValue)
        {
          string str1 = "row";
          mode = this.Mode;
          if (mode.HasValue)
          {
            mode = this.Mode;
            str1 = mode.Value.Serialize();
          }
          if (this.Type.HasValue)
          {
            string str2 = str1;
            type = this.Type;
            string str3 = type.Value.Serialize();
            str1 = str2 + ", " + str3;
          }
          dictionary["selectable"] = (object) str1;
        }
        mode = this.Mode;
        if (!mode.HasValue)
        {
          type = this.Type;
          if (!type.HasValue)
            dictionary["selectable"] = (object) true;
        }
      }
      return dictionary;
    }

    public TreeListSelectionMode? Mode { get; set; }

    public TreeListSelectionType? Type { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings() => new Dictionary<string, object>();
  }
}
