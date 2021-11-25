// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FloatingActionButtonAlignOffset
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FloatingActionButtonAlignOffset
  {
    public string Horizontal { get; set; }

    public string Vertical { get; set; }

    public Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Horizontal.HasValue())
        dictionary["x"] = (object) this.Horizontal;
      if (this.Vertical.HasValue())
        dictionary["y"] = (object) this.Vertical;
      return dictionary;
    }
  }
}
