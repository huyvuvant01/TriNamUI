// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ListBoxToolbarSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ListBoxToolbarSettings
  {
    public ListBoxToolbarSettings() => this.Tools = new List<string>();

    public List<string> Tools { get; private set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      List<string> tools = this.Tools;
      if ((tools != null ? (tools.Any<string>() ? 1 : 0) : 0) != 0)
        dictionary["tools"] = (object) this.Tools;
      return dictionary;
    }

    public ListBoxToolbarPosition? Position { get; set; }

    public ListBox ListBox { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ListBoxToolbarPosition? position = this.Position;
        ref ListBoxToolbarPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
