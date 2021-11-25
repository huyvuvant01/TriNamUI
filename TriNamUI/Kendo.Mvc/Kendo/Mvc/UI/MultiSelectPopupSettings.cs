// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MultiSelectPopupSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class MultiSelectPopupSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string AppendTo { get; set; }

    public string Origin { get; set; }

    public string Position { get; set; }

    public MultiSelect MultiSelect { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string appendTo = this.AppendTo;
      if ((appendTo != null ? (appendTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["appendTo"] = (object) this.AppendTo;
      string origin = this.Origin;
      if ((origin != null ? (origin.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["origin"] = (object) this.Origin;
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      return dictionary;
    }
  }
}
