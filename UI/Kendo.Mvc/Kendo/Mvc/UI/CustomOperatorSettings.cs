// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CustomOperatorSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class CustomOperatorSettings
  {
    public string Name { get; set; }

    public string Text { get; set; }

    public string Handler { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      string handler = this.Handler;
      if ((handler != null ? (handler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["handler"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.Handler
        };
      return dictionary;
    }
  }
}
