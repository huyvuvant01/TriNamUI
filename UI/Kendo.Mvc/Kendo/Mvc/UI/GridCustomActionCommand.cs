// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridCustomActionCommand
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridCustomActionCommand : GridCustomCommandBase
  {
    public ClientHandlerDescriptor Click { get; } = new ClientHandlerDescriptor();

    public override IDictionary<string, object> Serialize()
    {
      IDictionary<string, object> dictionary = base.Serialize();
      if (this.Text.HasValue())
        dictionary["text"] = (object) this.Text;
      if (this.Click.HasValue())
        dictionary["click"] = (object) this.Click;
      return dictionary;
    }
  }
}
