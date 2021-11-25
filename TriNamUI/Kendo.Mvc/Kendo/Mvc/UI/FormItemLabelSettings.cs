// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FormItemLabelSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FormItemLabelSettings
  {
    public string Text { get; set; }

    public bool? Optional { get; set; }

    public bool? Encoded { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Text.HasValue())
        dictionary["text"] = (object) this.Text;
      if (this.Optional.HasValue)
        dictionary["optional"] = (object) this.Optional;
      if (this.Encoded.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      return dictionary;
    }
  }
}
