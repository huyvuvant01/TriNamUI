// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FormMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FormMessagesSettings
  {
    public string Submit { get; set; }

    public string Clear { get; set; }

    public string Optional { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Submit.HasValue())
        dictionary["submit"] = (object) this.Submit;
      if (this.Clear.HasValue())
        dictionary["clear"] = (object) this.Clear;
      if (this.Optional.HasValue())
        dictionary["optional"] = (object) this.Optional;
      return dictionary;
    }
  }
}
